using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryIEConsultaArticulo
{
    internal class clsArchivo
    {
        public string NomArchivoRubros = "Rubros.csv";
        public string NomArchivoArticulos = "Articulos.csv";

        public void CargarRubros(ComboBox cmbRubros)
        {
            string datoLeido;

            cmbRubros.Items.Clear();

            StreamReader AD = new StreamReader(NomArchivoRubros);

            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                cmbRubros.Items.Add(datoLeido);
                datoLeido = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();
        }

        public void ListarPorRubro(DataGridView grilla, string rubro)
        {
            string datoLeido;
            string[] vecDatos;

            decimal costo;
            int stock;
            decimal valorStock;

            grilla.Rows.Clear();

            StreamReader AD = new StreamReader(NomArchivoArticulos);

            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');

                if (vecDatos[3] == rubro)
                {
                    costo = Convert.ToDecimal(vecDatos[2]);
                    stock = Convert.ToInt32(vecDatos[4]);
                    valorStock = costo * stock;

                    grilla.Rows.Add(
                        vecDatos[0],
                        vecDatos[1],
                        costo.ToString("C"),
                        stock,
                        valorStock.ToString("C")
                    );
                }

                datoLeido = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();
        }

        public int CantidadPorRubro(string rubro)
        {
            string datoLeido;
            string[] vecDatos;
            int cantidad = 0;

            StreamReader AD = new StreamReader(NomArchivoArticulos);

            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');

                if (vecDatos[3] == rubro)
                {
                    cantidad++;
                }

                datoLeido = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();

            return cantidad;
        }

        public decimal TotalValorStock(string rubro)
        {
            string datoLeido;
            string[] vecDatos;

            decimal costo;
            int stock;
            decimal total = 0;

            StreamReader AD = new StreamReader(NomArchivoArticulos);

            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');

                if (vecDatos[3] == rubro)
                {
                    costo = Convert.ToDecimal(vecDatos[2]);
                    stock = Convert.ToInt32(vecDatos[4]);

                    total = total + (costo * stock);
                }

                datoLeido = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();

            return total;
        }

        public void ExportarPorRubro(string rubro)
        {
            string datoLeido;
            string[] vecDatos;

            decimal costo;
            int stock;
            decimal valorStock;

            StreamReader AD = new StreamReader(NomArchivoArticulos);
            StreamWriter Reporte = new StreamWriter("ReporteArticulos.csv", false);

            Reporte.WriteLine("Codigo;Descripcion;Costo;Stock;Valor en Stock");

            datoLeido = AD.ReadLine();

            while (datoLeido != null)
            {
                vecDatos = datoLeido.Split(';');

                if (vecDatos[3] == rubro)
                {
                    costo = Convert.ToDecimal(vecDatos[2]);
                    stock = Convert.ToInt32(vecDatos[4]);
                    valorStock = costo * stock;

                    Reporte.Write(vecDatos[0]);
                    Reporte.Write(";");
                    Reporte.Write(vecDatos[1]);
                    Reporte.Write(";");
                    Reporte.Write(costo);
                    Reporte.Write(";");
                    Reporte.Write(stock);
                    Reporte.Write(";");
                    Reporte.WriteLine(valorStock);
                }

                datoLeido = AD.ReadLine();
            }

            AD.Close();
            AD.Dispose();

            Reporte.Close();
            Reporte.Dispose();
        }

    }
}

