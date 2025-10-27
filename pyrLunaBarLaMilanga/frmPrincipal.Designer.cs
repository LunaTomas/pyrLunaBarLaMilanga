namespace pyrLunaBarLaMilanga
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            dgvVentas = new DataGridView();
            clmComida = new DataGridViewTextBoxColumn();
            clmBebidasSinAlcohol = new DataGridViewTextBoxColumn();
            clmBebidasConAlcohol = new DataGridViewTextBoxColumn();
            clmPostres = new DataGridViewTextBoxColumn();
            btnValidar = new Button();
            btnMozoDelDia = new Button();
            btnTotales = new Button();
            btnCerrar = new Button();
            lblMozoDelDia = new Label();
            txtMozoDelDia = new TextBox();
            lblImporteMozo = new Label();
            txtImporteMozo = new TextBox();
            lblTotalComidas = new Label();
            txtTotalComidas = new TextBox();
            txtTotalBebidasSin = new TextBox();
            txtTotalBebidasCon = new TextBox();
            txtTotalPostres = new TextBox();
            txtTotalGeneral = new TextBox();
            lblTotalBebidasSin = new Label();
            lblTotalBebidasCon = new Label();
            lblTotalPostres = new Label();
            lblTotalGeneral = new Label();
            grpVendasDiarias = new GroupBox();
            grpMozoDelDia = new GroupBox();
            grpTotales = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            grpVendasDiarias.SuspendLayout();
            grpMozoDelDia.SuspendLayout();
            grpTotales.SuspendLayout();
            SuspendLayout();
            // 
            // dgvVentas
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { clmComida, clmBebidasSinAlcohol, clmBebidasConAlcohol, clmPostres });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.Location = new Point(6, 22);
            dgvVentas.Name = "dgvVentas";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvVentas.Size = new Size(544, 203);
            dgvVentas.TabIndex = 0;
            // 
            // clmComida
            // 
            clmComida.HeaderText = "Comida";
            clmComida.Name = "clmComida";
            // 
            // clmBebidasSinAlcohol
            // 
            clmBebidasSinAlcohol.HeaderText = "Bebidas sin alcohol";
            clmBebidasSinAlcohol.Name = "clmBebidasSinAlcohol";
            // 
            // clmBebidasConAlcohol
            // 
            clmBebidasConAlcohol.HeaderText = "Bebidas con alcohol";
            clmBebidasConAlcohol.Name = "clmBebidasConAlcohol";
            // 
            // clmPostres
            // 
            clmPostres.HeaderText = "Postres";
            clmPostres.Name = "clmPostres";
            // 
            // btnValidar
            // 
            btnValidar.Font = new Font("Segoe UI", 15.75F);
            btnValidar.Location = new Point(6, 231);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(148, 39);
            btnValidar.TabIndex = 1;
            btnValidar.Text = "Validar datos";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // btnMozoDelDia
            // 
            btnMozoDelDia.Font = new Font("Segoe UI", 15.75F);
            btnMozoDelDia.Location = new Point(6, 22);
            btnMozoDelDia.Name = "btnMozoDelDia";
            btnMozoDelDia.Size = new Size(148, 39);
            btnMozoDelDia.TabIndex = 2;
            btnMozoDelDia.Text = "Mozo del día";
            btnMozoDelDia.UseVisualStyleBackColor = true;
            btnMozoDelDia.Click += btnMozoDelDia_Click;
            // 
            // btnTotales
            // 
            btnTotales.Font = new Font("Segoe UI", 15.75F);
            btnTotales.Location = new Point(6, 22);
            btnTotales.Name = "btnTotales";
            btnTotales.Size = new Size(148, 39);
            btnTotales.TabIndex = 3;
            btnTotales.Text = "Totales";
            btnTotales.UseVisualStyleBackColor = true;
            btnTotales.Click += btnTotales_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 15.75F);
            btnCerrar.Location = new Point(467, 727);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(102, 39);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblMozoDelDia
            // 
            lblMozoDelDia.AutoSize = true;
            lblMozoDelDia.Font = new Font("Segoe UI", 15.75F);
            lblMozoDelDia.Location = new Point(12, 67);
            lblMozoDelDia.Name = "lblMozoDelDia";
            lblMozoDelDia.Size = new Size(94, 30);
            lblMozoDelDia.TabIndex = 5;
            lblMozoDelDia.Text = "Nombre:";
            // 
            // txtMozoDelDia
            // 
            txtMozoDelDia.Font = new Font("Segoe UI", 15.75F);
            txtMozoDelDia.Location = new Point(160, 64);
            txtMozoDelDia.Name = "txtMozoDelDia";
            txtMozoDelDia.ReadOnly = true;
            txtMozoDelDia.Size = new Size(390, 35);
            txtMozoDelDia.TabIndex = 6;
            // 
            // lblImporteMozo
            // 
            lblImporteMozo.AutoSize = true;
            lblImporteMozo.Font = new Font("Segoe UI", 15.75F);
            lblImporteMozo.Location = new Point(12, 108);
            lblImporteMozo.Name = "lblImporteMozo";
            lblImporteMozo.Size = new Size(139, 30);
            lblImporteMozo.TabIndex = 7;
            lblImporteMozo.Text = "Importe total:";
            // 
            // txtImporteMozo
            // 
            txtImporteMozo.Font = new Font("Segoe UI", 15.75F);
            txtImporteMozo.Location = new Point(162, 105);
            txtImporteMozo.Name = "txtImporteMozo";
            txtImporteMozo.ReadOnly = true;
            txtImporteMozo.Size = new Size(390, 35);
            txtImporteMozo.TabIndex = 8;
            // 
            // lblTotalComidas
            // 
            lblTotalComidas.AutoSize = true;
            lblTotalComidas.Font = new Font("Segoe UI", 15.75F);
            lblTotalComidas.Location = new Point(6, 64);
            lblTotalComidas.Name = "lblTotalComidas";
            lblTotalComidas.Size = new Size(98, 30);
            lblTotalComidas.TabIndex = 9;
            lblTotalComidas.Text = "Comidas:";
            // 
            // txtTotalComidas
            // 
            txtTotalComidas.Font = new Font("Segoe UI", 15.75F);
            txtTotalComidas.Location = new Point(160, 61);
            txtTotalComidas.Name = "txtTotalComidas";
            txtTotalComidas.ReadOnly = true;
            txtTotalComidas.Size = new Size(390, 35);
            txtTotalComidas.TabIndex = 10;
            // 
            // txtTotalBebidasSin
            // 
            txtTotalBebidasSin.Font = new Font("Segoe UI", 15.75F);
            txtTotalBebidasSin.Location = new Point(160, 102);
            txtTotalBebidasSin.Name = "txtTotalBebidasSin";
            txtTotalBebidasSin.ReadOnly = true;
            txtTotalBebidasSin.Size = new Size(390, 35);
            txtTotalBebidasSin.TabIndex = 11;
            // 
            // txtTotalBebidasCon
            // 
            txtTotalBebidasCon.Font = new Font("Segoe UI", 15.75F);
            txtTotalBebidasCon.Location = new Point(160, 143);
            txtTotalBebidasCon.Name = "txtTotalBebidasCon";
            txtTotalBebidasCon.ReadOnly = true;
            txtTotalBebidasCon.Size = new Size(390, 35);
            txtTotalBebidasCon.TabIndex = 12;
            // 
            // txtTotalPostres
            // 
            txtTotalPostres.Font = new Font("Segoe UI", 15.75F);
            txtTotalPostres.Location = new Point(160, 184);
            txtTotalPostres.Name = "txtTotalPostres";
            txtTotalPostres.ReadOnly = true;
            txtTotalPostres.Size = new Size(390, 35);
            txtTotalPostres.TabIndex = 13;
            // 
            // txtTotalGeneral
            // 
            txtTotalGeneral.Font = new Font("Segoe UI", 15.75F);
            txtTotalGeneral.Location = new Point(160, 225);
            txtTotalGeneral.Name = "txtTotalGeneral";
            txtTotalGeneral.ReadOnly = true;
            txtTotalGeneral.Size = new Size(390, 35);
            txtTotalGeneral.TabIndex = 14;
            // 
            // lblTotalBebidasSin
            // 
            lblTotalBebidasSin.AutoSize = true;
            lblTotalBebidasSin.Font = new Font("Segoe UI", 15.75F);
            lblTotalBebidasSin.Location = new Point(6, 105);
            lblTotalBebidasSin.Name = "lblTotalBebidasSin";
            lblTotalBebidasSin.Size = new Size(148, 30);
            lblTotalBebidasSin.TabIndex = 15;
            lblTotalBebidasSin.Text = "Beb. s/alcohol:";
            // 
            // lblTotalBebidasCon
            // 
            lblTotalBebidasCon.AutoSize = true;
            lblTotalBebidasCon.Font = new Font("Segoe UI", 15.75F);
            lblTotalBebidasCon.Location = new Point(6, 146);
            lblTotalBebidasCon.Name = "lblTotalBebidasCon";
            lblTotalBebidasCon.Size = new Size(149, 30);
            lblTotalBebidasCon.TabIndex = 16;
            lblTotalBebidasCon.Text = "Beb. c/alcohol:";
            // 
            // lblTotalPostres
            // 
            lblTotalPostres.AutoSize = true;
            lblTotalPostres.Font = new Font("Segoe UI", 15.75F);
            lblTotalPostres.Location = new Point(6, 187);
            lblTotalPostres.Name = "lblTotalPostres";
            lblTotalPostres.Size = new Size(84, 30);
            lblTotalPostres.TabIndex = 17;
            lblTotalPostres.Text = "Postres:";
            // 
            // lblTotalGeneral
            // 
            lblTotalGeneral.AutoSize = true;
            lblTotalGeneral.Font = new Font("Segoe UI", 15.75F);
            lblTotalGeneral.Location = new Point(6, 228);
            lblTotalGeneral.Name = "lblTotalGeneral";
            lblTotalGeneral.Size = new Size(137, 30);
            lblTotalGeneral.TabIndex = 18;
            lblTotalGeneral.Text = "Total general:";
            // 
            // grpVendasDiarias
            // 
            grpVendasDiarias.Controls.Add(dgvVentas);
            grpVendasDiarias.Controls.Add(btnValidar);
            grpVendasDiarias.Location = new Point(11, 9);
            grpVendasDiarias.Name = "grpVendasDiarias";
            grpVendasDiarias.Size = new Size(558, 278);
            grpVendasDiarias.TabIndex = 19;
            grpVendasDiarias.TabStop = false;
            grpVendasDiarias.Text = "Ventas diarias de mozos";
            // 
            // grpMozoDelDia
            // 
            grpMozoDelDia.Controls.Add(btnMozoDelDia);
            grpMozoDelDia.Controls.Add(lblMozoDelDia);
            grpMozoDelDia.Controls.Add(txtMozoDelDia);
            grpMozoDelDia.Controls.Add(lblImporteMozo);
            grpMozoDelDia.Controls.Add(txtImporteMozo);
            grpMozoDelDia.Location = new Point(11, 293);
            grpMozoDelDia.Name = "grpMozoDelDia";
            grpMozoDelDia.Size = new Size(558, 148);
            grpMozoDelDia.TabIndex = 20;
            grpMozoDelDia.TabStop = false;
            grpMozoDelDia.Text = "Mozo del día";
            // 
            // grpTotales
            // 
            grpTotales.Controls.Add(txtTotalGeneral);
            grpTotales.Controls.Add(btnTotales);
            grpTotales.Controls.Add(lblTotalComidas);
            grpTotales.Controls.Add(lblTotalGeneral);
            grpTotales.Controls.Add(txtTotalComidas);
            grpTotales.Controls.Add(lblTotalPostres);
            grpTotales.Controls.Add(txtTotalBebidasSin);
            grpTotales.Controls.Add(lblTotalBebidasCon);
            grpTotales.Controls.Add(txtTotalBebidasCon);
            grpTotales.Controls.Add(lblTotalBebidasSin);
            grpTotales.Controls.Add(txtTotalPostres);
            grpTotales.Location = new Point(11, 447);
            grpTotales.Name = "grpTotales";
            grpTotales.Size = new Size(558, 274);
            grpTotales.TabIndex = 9;
            grpTotales.TabStop = false;
            grpTotales.Text = "Ventas totales";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 773);
            Controls.Add(grpTotales);
            Controls.Add(grpMozoDelDia);
            Controls.Add(grpVendasDiarias);
            Controls.Add(btnCerrar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bar la milanga";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            grpVendasDiarias.ResumeLayout(false);
            grpMozoDelDia.ResumeLayout(false);
            grpMozoDelDia.PerformLayout();
            grpTotales.ResumeLayout(false);
            grpTotales.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVentas;
        private Button btnValidar;
        private Button btnMozoDelDia;
        private Button btnTotales;
        private Button btnCerrar;
        private Label lblMozoDelDia;
        private TextBox txtMozoDelDia;
        private Label lblImporteMozo;
        private TextBox txtImporteMozo;
        private Label lblTotalComidas;
        private TextBox txtTotalComidas;
        private TextBox txtTotalBebidasSin;
        private TextBox txtTotalBebidasCon;
        private TextBox txtTotalPostres;
        private TextBox txtTotalGeneral;
        private Label lblTotalBebidasSin;
        private Label lblTotalBebidasCon;
        private Label lblTotalPostres;
        private Label lblTotalGeneral;
        private GroupBox grpVendasDiarias;
        private GroupBox grpMozoDelDia;
        private GroupBox grpTotales;
        private DataGridViewTextBoxColumn clmComida;
        private DataGridViewTextBoxColumn clmBebidasSinAlcohol;
        private DataGridViewTextBoxColumn clmBebidasConAlcohol;
        private DataGridViewTextBoxColumn clmPostres;
    }
}
