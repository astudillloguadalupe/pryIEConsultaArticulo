using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIEConsultaArticulo
{
    internal class clsArticulos
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador;

        private string CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Articulos.mdb";
        private string TablaArticulos = "Articulo";
        private string TablaRubros = "Rubro";

        private string rubroActual = "";
        private int cantidad = 0;
        private decimal totalStock = 0;

        public int CantidadArticulos { get { return cantidad; } }
        public decimal TotalValorStock { get { return totalStock; } }

        public void CargarRubros(ComboBox cmbRubros)
        {
            try
            {
                cmbRubros.Items.Clear();
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = TablaRubros;

                OleDbDataReader DR = comando.ExecuteReader();
                while (DR.Read())
                {
                    cmbRubros.Items.Add(DR.GetString(1));
                }
                conexion.Close();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }


        public void ListarPorRubro(DataGridView grilla, string rubro)
        {
            try
            {
                rubroActual = rubro;
                cantidad = 0;
                totalStock = 0;
                grilla.Rows.Clear();

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Articulo WHERE Rubro = '" + rubro + "'";

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, TablaArticulos);
                conexion.Close();

                if (DS.Tables[TablaArticulos].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[TablaArticulos].Rows)
                    {
                        decimal costo = Convert.ToDecimal(fila["Costo"]);
                        int stock = Convert.ToInt32(fila["Stock"]);
                        decimal valorStock = costo * stock;

                        grilla.Rows.Add(
                            fila["Codigo"].ToString(),
                            fila["Descripcion"].ToString(),
                            costo.ToString("C"),
                            stock,
                            valorStock.ToString("C")
                        );

                        cantidad++;
                        totalStock += valorStock;
                    }
                }
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }

        

        public void Imprimir(PrintPageEventArgs reporte)
        {
            try
            {
                Font letraTitulo1 = new Font("Arial", 18, FontStyle.Bold);
                Font letraTitulo2 = new Font("Arial", 11, FontStyle.Bold);
                Font letraTexto = new Font("Arial", 9);
                int f = 180;

                reporte.Graphics.DrawString(
                    "Listado de Artículos – Rubro: " + rubroActual,
                    letraTitulo1, Brushes.DarkBlue, 50, 60);

                reporte.Graphics.DrawString("Código", letraTitulo2, Brushes.Navy, 50, 140);
                reporte.Graphics.DrawString("Descripción", letraTitulo2, Brushes.Navy, 160, 140);
                reporte.Graphics.DrawString("Costo", letraTitulo2, Brushes.Navy, 560, 140);
                reporte.Graphics.DrawString("Stock", letraTitulo2, Brushes.Navy, 660, 140);
                reporte.Graphics.DrawString("Valor Stock", letraTitulo2, Brushes.Navy, 750, 140);
                reporte.Graphics.DrawLine(Pens.Navy, 50, 158, 740, 158);

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Articulo WHERE Rubro = '" + rubroActual + "'";

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, TablaArticulos);

                if (DS.Tables[TablaArticulos].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[TablaArticulos].Rows)
                    {
                        decimal costo = Convert.ToDecimal(fila["Costo"]);
                        int stock = Convert.ToInt32(fila["Stock"]);
                        decimal valorStock = costo * stock;

                        reporte.Graphics.DrawString(fila["Codigo"].ToString(), letraTexto, Brushes.Black, 50, f);
                        reporte.Graphics.DrawString(fila["Descripcion"].ToString(), letraTexto, Brushes.Black, 160, f);
                        reporte.Graphics.DrawString(costo.ToString("C"), letraTexto, Brushes.Black, 560, f);
                        reporte.Graphics.DrawString(stock.ToString(), letraTexto, Brushes.Black, 660, f);
                        reporte.Graphics.DrawString(valorStock.ToString("C"), letraTexto, Brushes.Black, 740, f);
                        f += 18;
                    }
                }

                conexion.Close();

                f += 20;
                reporte.Graphics.DrawLine(Pens.Navy, 50, f, 740, f);
                f += 10;
                reporte.Graphics.DrawString(
                    "Total artículos: " + cantidad + "   |   Total valor en stock: " + totalStock.ToString("C"),
                    letraTitulo2, Brushes.DarkBlue, 50, f);
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }

        public void ExportarPorRubro(string rubro, string rutaArchivo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Articulo WHERE Rubro = '" + rubro + "'";

                OleDbDataReader DR = comando.ExecuteReader();
                StreamWriter reporte = new StreamWriter(rutaArchivo, false, Encoding.UTF8);

                // TÍTULO
                reporte.WriteLine("Reporte de Artículos por Rubro");
                reporte.WriteLine("Rubro: " + rubro);
                reporte.WriteLine("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                reporte.WriteLine();
                reporte.WriteLine("Codigo;Descripcion;Costo;Stock;Valor en Stock");

                int cantidadExport = 0;
                decimal totalStockExport = 0;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        decimal costo = DR.GetDecimal(2);
                        int stock = DR.GetInt32(4);
                        decimal valorStock = costo * stock;

                        reporte.Write(DR["Codigo"].ToString()); reporte.Write(";");
                        reporte.Write(DR["Descripcion"].ToString()); reporte.Write(";");
                        reporte.Write(costo); reporte.Write(";");
                        reporte.Write(stock); reporte.Write(";");
                        reporte.WriteLine(valorStock);

                        cantidadExport++;
                        totalStockExport += valorStock;
                    }

                }
                // TOTALES
                reporte.WriteLine();
                reporte.WriteLine("Cantidad de artículos;" + cantidadExport);
                reporte.WriteLine("Total valor en stock;" + totalStockExport);

                reporte.Close();
                conexion.Close();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }

    
        

    }
}