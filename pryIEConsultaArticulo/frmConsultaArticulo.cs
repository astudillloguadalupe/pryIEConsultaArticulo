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
            if (cmbRubro.SelectedIndex == -1)
            {

                btnConsultar.Enabled = false;
            } 
            else
            {
                btnConsultar.Enabled = true;
            }

        }
    }
}
