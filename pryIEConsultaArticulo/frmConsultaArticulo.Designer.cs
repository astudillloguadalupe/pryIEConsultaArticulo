namespace pryIEConsultaArticulo
{
    partial class frmConsultaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.grpRubro = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblRubro = new System.Windows.Forms.Label();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.colCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotalRTA = new System.Windows.Forms.Label();
            this.lblCantRTA = new System.Windows.Forms.Label();
            this.LinkInfo = new System.Windows.Forms.LinkLabel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dlgGuardar = new System.Windows.Forms.SaveFileDialog();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            this.grpRubro.SuspendLayout();
            this.grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(233, 73);
            this.cmbRubro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(249, 24);
            this.cmbRubro.TabIndex = 1;
            this.cmbRubro.SelectedIndexChanged += new System.EventHandler(this.cmbRubro_SelectedIndexChanged);
            // 
            // grpRubro
            // 
            this.grpRubro.Controls.Add(this.btnConsultar);
            this.grpRubro.Controls.Add(this.lblRubro);
            this.grpRubro.Controls.Add(this.cmbRubro);
            this.grpRubro.Location = new System.Drawing.Point(11, 30);
            this.grpRubro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpRubro.Name = "grpRubro";
            this.grpRubro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpRubro.Size = new System.Drawing.Size(880, 196);
            this.grpRubro.TabIndex = 1;
            this.grpRubro.TabStop = false;
            this.grpRubro.Text = "Rubro";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Enabled = false;
            this.btnConsultar.Location = new System.Drawing.Point(567, 146);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(176, 28);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar Articulos";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(65, 76);
            this.lblRubro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(132, 16);
            this.lblRubro.TabIndex = 0;
            this.lblRubro.Text = "Seleccione el Rubro:";
            // 
            // grpListado
            // 
            this.grpListado.Controls.Add(this.dgvGrilla);
            this.grpListado.Location = new System.Drawing.Point(11, 223);
            this.grpListado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpListado.Name = "grpListado";
            this.grpListado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpListado.Size = new System.Drawing.Size(880, 257);
            this.grpListado.TabIndex = 2;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "Listado de Articulos";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCódigo,
            this.colDescripción,
            this.colCosto,
            this.colStock,
            this.colValorStock});
            this.dgvGrilla.Location = new System.Drawing.Point(9, 23);
            this.dgvGrilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.RowHeadersWidth = 51;
            this.dgvGrilla.Size = new System.Drawing.Size(863, 226);
            this.dgvGrilla.TabIndex = 0;
            // 
            // colCódigo
            // 
            this.colCódigo.HeaderText = "Código";
            this.colCódigo.MinimumWidth = 6;
            this.colCódigo.Name = "colCódigo";
            this.colCódigo.Width = 125;
            // 
            // colDescripción
            // 
            this.colDescripción.HeaderText = "Descripción";
            this.colDescripción.MinimumWidth = 6;
            this.colDescripción.Name = "colDescripción";
            this.colDescripción.Width = 180;
            // 
            // colCosto
            // 
            this.colCosto.HeaderText = "Costo";
            this.colCosto.MinimumWidth = 6;
            this.colCosto.Name = "colCosto";
            this.colCosto.Width = 125;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.MinimumWidth = 6;
            this.colStock.Name = "colStock";
            this.colStock.Width = 125;
            // 
            // colValorStock
            // 
            this.colValorStock.HeaderText = "Valor en Stock";
            this.colValorStock.MinimumWidth = 6;
            this.colValorStock.Name = "colValorStock";
            this.colValorStock.Width = 125;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(428, 522);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(176, 28);
            this.btnExportar.TabIndex = 3;
            this.btnExportar.Text = "Exportar a CSV";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(20, 539);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(110, 16);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Valor Stock";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(20, 498);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(134, 16);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad de Articulos";
            // 
            // lblTotalRTA
            // 
            this.lblTotalRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalRTA.Location = new System.Drawing.Point(212, 527);
            this.lblTotalRTA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRTA.Name = "lblTotalRTA";
            this.lblTotalRTA.Size = new System.Drawing.Size(133, 28);
            this.lblTotalRTA.TabIndex = 0;
            // 
            // lblCantRTA
            // 
            this.lblCantRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantRTA.Location = new System.Drawing.Point(212, 486);
            this.lblCantRTA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantRTA.Name = "lblCantRTA";
            this.lblCantRTA.Size = new System.Drawing.Size(133, 28);
            this.lblCantRTA.TabIndex = 0;
            // 
            // LinkInfo
            // 
            this.LinkInfo.AutoSize = true;
            this.LinkInfo.Location = new System.Drawing.Point(720, 11);
            this.LinkInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LinkInfo.Name = "LinkInfo";
            this.LinkInfo.Size = new System.Drawing.Size(146, 16);
            this.LinkInfo.TabIndex = 0;
            this.LinkInfo.TabStop = true;
            this.LinkInfo.Text = "Informacion del Alumno";
            this.LinkInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkInfo_LinkClicked);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(611, 522);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(176, 28);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage);
            // 
            // frmConsultaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 566);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.grpListado);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lblCantRTA);
            this.Controls.Add(this.lblTotalRTA);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grpRubro);
            this.Controls.Add(this.LinkInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConsultaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Articulos por Rubro";
            this.Load += new System.EventHandler(this.frmConsultaArticulo_Load);
            this.grpRubro.ResumeLayout(false);
            this.grpRubro.PerformLayout();
            this.grpListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.GroupBox grpRubro;
        private System.Windows.Forms.GroupBox grpListado;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotalRTA;
        private System.Windows.Forms.Label lblCantRTA;
        private System.Windows.Forms.LinkLabel LinkInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorStock;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.SaveFileDialog dlgGuardar;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocumento;
    }
}