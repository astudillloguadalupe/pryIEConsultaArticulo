using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIEConsultaArticulo
{
    public partial class frmConsultaArticulo : Form
    {
        public frmConsultaArticulo()
        {
            InitializeComponent();
        }

        clsArchivo x = new clsArchivo();

        private void LinkInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Analista de Sistemas\n" +
                 "Laboratorio de Programación 2\n" +
                  "1º Instancia Evaluativa\n" +
                    "DNI: 46767530\n" +
                    "Guadalupe Astudillo Pini",
                    "Información del Alumno");
        }

        private void cmbRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRubro.Text != "")
            {
                btnConsultar.Enabled = true;
            }
            else
            {
                btnConsultar.Enabled = false;
            }

        }

        private void frmConsultaArticulo_Load(object sender, EventArgs e)
        {
            x.CargarRubros(cmbRubro);
            btnConsultar.Enabled = false;
            btnExportar.Enabled = false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            x.ListarPorRubro(dgvGrilla, cmbRubro.Text);

            lblCantRTA.Text = x.CantidadPorRubro(cmbRubro.Text).ToString();
            lblTotalRTA.Text = x.TotalValorStock(cmbRubro.Text).ToString("C");

            btnExportar.Enabled = true;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            x.ExportarPorRubro(cmbRubro.Text);
            MessageBox.Show("Archivo exportado correctamente");
        }
    }
}
