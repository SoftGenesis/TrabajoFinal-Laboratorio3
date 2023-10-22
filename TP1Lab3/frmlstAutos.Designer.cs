namespace TP1Lab3
{
    partial class frmlstAutos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnLst = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVolver = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMarca = new System.Windows.Forms.CheckBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.chkCliente = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.prtDoc = new System.Drawing.Printing.PrintDocument();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnExp.Location = new System.Drawing.Point(492, 642);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(114, 44);
            this.btnExp.TabIndex = 46;
            this.btnExp.Text = "Exportar";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnLst
            // 
            this.btnLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLst.Location = new System.Drawing.Point(277, 642);
            this.btnLst.Name = "btnLst";
            this.btnLst.Size = new System.Drawing.Size(114, 44);
            this.btnLst.TabIndex = 45;
            this.btnLst.Text = "Listar";
            this.btnLst.UseVisualStyleBackColor = true;
            this.btnLst.Click += new System.EventHandler(this.btnLst_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Propietario,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv.Location = new System.Drawing.Point(12, 144);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1126, 457);
            this.dgv.TabIndex = 44;
            // 
            // Propietario
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Propietario.DefaultCellStyle = dataGridViewCellStyle1;
            this.Propietario.HeaderText = "Patente";
            this.Propietario.MinimumWidth = 6;
            this.Propietario.Name = "Propietario";
            this.Propietario.Width = 125;
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "Marca";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Modelo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Año";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "Rep. Vigentes";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "Cliente";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVolver.Location = new System.Drawing.Point(956, 700);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(182, 44);
            this.btnVolver.TabIndex = 47;
            this.btnVolver.Text = "Ir/Salir";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(930, 618);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 48);
            this.label7.TabIndex = 61;
            this.label7.Text = "Seleccione Ventana o Presione Salir";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // cmbVolver
            // 
            this.cmbVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cmbVolver.FormattingEnabled = true;
            this.cmbVolver.Items.AddRange(new object[] {
            " --Agregados--",
            "Agregar Cliente",
            "Agregar Auto",
            "Agregar Reparación",
            "Agregar Repuestos",
            "--Listas--",
            "Lista de Clientes",
            "Lista de Reparaciones",
            "Lista de Repuestos",
            "--Estadisticas--",
            "Grafico Autos"});
            this.cmbVolver.Location = new System.Drawing.Point(930, 669);
            this.cmbVolver.Name = "cmbVolver";
            this.cmbVolver.Size = new System.Drawing.Size(207, 30);
            this.cmbVolver.TabIndex = 60;
            this.cmbVolver.SelectedIndexChanged += new System.EventHandler(this.cmbVolver_SelectedIndexChanged);
            // 
            // cmbCliente
            // 
            this.cmbCliente.Enabled = false;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Items.AddRange(new object[] {
            "--"});
            this.cmbCliente.Location = new System.Drawing.Point(171, 23);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(166, 30);
            this.cmbCliente.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 51);
            this.label1.TabIndex = 77;
            this.label1.Text = "Seleccione Caracteristicas de Lista o Presione Listar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMarca);
            this.groupBox1.Controls.Add(this.cmbMarca);
            this.groupBox1.Controls.Add(this.chkCliente);
            this.groupBox1.Controls.Add(this.cmbCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.groupBox1.ForeColor = System.Drawing.Color.Olive;
            this.groupBox1.Location = new System.Drawing.Point(345, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 73);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            // 
            // chkMarca
            // 
            this.chkMarca.AutoSize = true;
            this.chkMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.chkMarca.Location = new System.Drawing.Point(395, 27);
            this.chkMarca.Name = "chkMarca";
            this.chkMarca.Size = new System.Drawing.Size(114, 26);
            this.chkMarca.TabIndex = 82;
            this.chkMarca.Text = "Por Marca";
            this.chkMarca.UseVisualStyleBackColor = true;
            this.chkMarca.CheckedChanged += new System.EventHandler(this.chkMarca_CheckedChanged);
            // 
            // cmbMarca
            // 
            this.cmbMarca.Enabled = false;
            this.cmbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "--"});
            this.cmbMarca.Location = new System.Drawing.Point(560, 23);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(166, 30);
            this.cmbMarca.TabIndex = 81;
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.chkCliente.Location = new System.Drawing.Point(16, 27);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(121, 26);
            this.chkCliente.TabIndex = 80;
            this.chkCliente.Text = "Por Cliente";
            this.chkCliente.UseVisualStyleBackColor = true;
            this.chkCliente.CheckedChanged += new System.EventHandler(this.chkCliente_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnImprimir.Location = new System.Drawing.Point(698, 642);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(114, 44);
            this.btnImprimir.TabIndex = 86;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // prtDoc
            // 
            this.prtDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDoc_PrintPage);
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // frmlstAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP1Lab3.Properties.Resources.TallerMecanico;
            this.ClientSize = new System.Drawing.Size(1150, 750);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbVolver);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnLst);
            this.Controls.Add(this.dgv);
            this.Name = "frmlstAutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Autos";
            this.Load += new System.EventHandler(this.frmlstAutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnLst;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVolver;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.CheckBox chkCliente;
        private System.Windows.Forms.CheckBox chkMarca;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument prtDoc;
        private System.Windows.Forms.PrintDialog prtVentana;
    }
}