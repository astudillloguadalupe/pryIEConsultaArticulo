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
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblRubro = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotalRTA = new System.Windows.Forms.Label();
            this.lblCantRTA = new System.Windows.Forms.Label();
            this.LinkInfo = new System.Windows.Forms.LinkLabel();
            this.colCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpRubro.SuspendLayout();
            this.grpListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(175, 59);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(188, 21);
            this.cmbRubro.TabIndex = 0;
            this.cmbRubro.SelectedIndexChanged += new System.EventHandler(this.cmbRubro_SelectedIndexChanged);
            // 
            // grpRubro
            // 
            this.grpRubro.Controls.Add(this.btnConsultar);
            this.grpRubro.Controls.Add(this.lblRubro);
            this.grpRubro.Controls.Add(this.cmbRubro);
            this.grpRubro.Location = new System.Drawing.Point(8, 24);
            this.grpRubro.Name = "grpRubro";
            this.grpRubro.Size = new System.Drawing.Size(660, 159);
            this.grpRubro.TabIndex = 1;
            this.grpRubro.TabStop = false;
            this.grpRubro.Text = "Rubro";
            // 
            // grpListado
            // 
            this.grpListado.Controls.Add(this.dgvGrilla);
            this.grpListado.Location = new System.Drawing.Point(8, 181);
            this.grpListado.Name = "grpListado";
            this.grpListado.Size = new System.Drawing.Size(660, 209);
            this.grpListado.TabIndex = 0;
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
            this.dgvGrilla.Location = new System.Drawing.Point(7, 19);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(647, 184);
            this.dgvGrilla.TabIndex = 0;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(433, 424);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(132, 23);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "Exportar a CSV";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(425, 119);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(132, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar Articulos";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(49, 62);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(106, 13);
            this.lblRubro.TabIndex = 4;
            this.lblRubro.Text = "Seleccione el Rubro:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(15, 438);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(89, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total Valor Stock";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(15, 405);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(107, 13);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad de Articulos";
            // 
            // lblTotalRTA
            // 
            this.lblTotalRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalRTA.Location = new System.Drawing.Point(159, 428);
            this.lblTotalRTA.Name = "lblTotalRTA";
            this.lblTotalRTA.Size = new System.Drawing.Size(100, 23);
            this.lblTotalRTA.TabIndex = 7;
            // 
            // lblCantRTA
            // 
            this.lblCantRTA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantRTA.Location = new System.Drawing.Point(159, 395);
            this.lblCantRTA.Name = "lblCantRTA";
            this.lblCantRTA.Size = new System.Drawing.Size(100, 23);
            this.lblCantRTA.TabIndex = 8;
            // 
            // LinkInfo
            // 
            this.LinkInfo.AutoSize = true;
            this.LinkInfo.Location = new System.Drawing.Point(540, 9);
            this.LinkInfo.Name = "LinkInfo";
            this.LinkInfo.Size = new System.Drawing.Size(117, 13);
            this.LinkInfo.TabIndex = 9;
            this.LinkInfo.TabStop = true;
            this.LinkInfo.Text = "Informacion del Alumno";
            this.LinkInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkInfo_LinkClicked);
            // 
            // colCódigo
            // 
            this.colCódigo.HeaderText = "Código";
            this.colCódigo.Name = "colCódigo";
            // 
            // colDescripción
            // 
            this.colDescripción.HeaderText = "Descripción";
            this.colDescripción.Name = "colDescripción";
            this.colDescripción.Width = 180;
            // 
            // colCosto
            // 
            this.colCosto.HeaderText = "Costo";
            this.colCosto.Name = "colCosto";
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            // 
            // colValorStock
            // 
            this.colValorStock.HeaderText = "Valor en Stock";
            this.colValorStock.Name = "colValorStock";
            this.colValorStock.Width = 125;
            // 
            // frmConsultaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 460);
            this.Controls.Add(this.grpListado);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lblCantRTA);
            this.Controls.Add(this.lblTotalRTA);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grpRubro);
            this.Controls.Add(this.LinkInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmConsultaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Articulos por Rubro";
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
    }
}