namespace TP1Lab3
{
    partial class frmlstReparaciones
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnLst = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVolver = new System.Windows.Forms.ComboBox();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAuto = new System.Windows.Forms.ComboBox();
            this.chkCliente = new System.Windows.Forms.CheckBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDoc = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVolver.Location = new System.Drawing.Point(1278, 691);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(182, 44);
            this.btnVolver.TabIndex = 55;
            this.btnVolver.Text = "Ir/Salir";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnExp.Location = new System.Drawing.Point(714, 587);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(114, 44);
            this.btnExp.TabIndex = 54;
            this.btnExp.Text = "Exportar";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnLst
            // 
            this.btnLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLst.Location = new System.Drawing.Point(514, 587);
            this.btnLst.Name = "btnLst";
            this.btnLst.Size = new System.Drawing.Size(114, 44);
            this.btnLst.TabIndex = 53;
            this.btnLst.Text = "Listar";
            this.btnLst.UseVisualStyleBackColor = true;
            this.btnLst.Click += new System.EventHandler(this.btnLst_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Propietario,
            this.Column5,
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4});
            this.dgv.Location = new System.Drawing.Point(12, 145);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1437, 423);
            this.dgv.TabIndex = 52;
            // 
            // Propietario
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Propietario.DefaultCellStyle = dataGridViewCellStyle1;
            this.Propietario.HeaderText = "Reparacion";
            this.Propietario.MinimumWidth = 6;
            this.Propietario.Name = "Propietario";
            this.Propietario.Width = 300;
            // 
            // Column5
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Fecha";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Falla";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Repuesto";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column2.HeaderText = "Marca";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "Propietario";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 145;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(1252, 609);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 48);
            this.label7.TabIndex = 65;
            this.label7.Text = "Seleccione Ventana o Presione Salir";
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
            "Lista de Autos",
            "Lista de Clientes",
            "Lista de Repuestos",
            "--Estadisticas--",
            "Grafico Autos"});
            this.cmbVolver.Location = new System.Drawing.Point(1252, 660);
            this.cmbVolver.Name = "cmbVolver";
            this.cmbVolver.Size = new System.Drawing.Size(207, 30);
            this.cmbVolver.TabIndex = 64;
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.chkAuto.Location = new System.Drawing.Point(707, 31);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(102, 26);
            this.chkAuto.TabIndex = 73;
            this.chkAuto.Text = "Por Auto";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(178, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 63);
            this.label1.TabIndex = 72;
            this.label1.Text = "Seleccione Caracteristicas de Lista o Presione Listar";
            // 
            // cmbAuto
            // 
            this.cmbAuto.Enabled = false;
            this.cmbAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cmbAuto.FormattingEnabled = true;
            this.cmbAuto.Items.AddRange(new object[] {
            "--"});
            this.cmbAuto.Location = new System.Drawing.Point(861, 22);
            this.cmbAuto.Name = "cmbAuto";
            this.cmbAuto.Size = new System.Drawing.Size(207, 30);
            this.cmbAuto.TabIndex = 71;
            // 
            // chkCliente
            // 
            this.chkCliente.AutoSize = true;
            this.chkCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.chkCliente.Location = new System.Drawing.Point(707, 94);
            this.chkCliente.Name = "chkCliente";
            this.chkCliente.Size = new System.Drawing.Size(121, 26);
            this.chkCliente.TabIndex = 75;
            this.chkCliente.Text = "Por Cliente";
            this.chkCliente.UseVisualStyleBackColor = true;
            this.chkCliente.CheckedChanged += new System.EventHandler(this.chkCliente_CheckedChanged);
            // 
            // cmbCliente
            // 
            this.cmbCliente.Enabled = false;
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Items.AddRange(new object[] {
            "--"});
            this.cmbCliente.Location = new System.Drawing.Point(861, 90);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(207, 30);
            this.cmbCliente.TabIndex = 74;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnImprimir.Location = new System.Drawing.Point(894, 587);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(114, 44);
            this.btnImprimir.TabIndex = 87;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // prtDoc
            // 
            this.prtDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDoc_PrintPage);
            // 
            // frmlstReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP1Lab3.Properties.Resources.ImagenTaller;
            this.ClientSize = new System.Drawing.Size(1535, 738);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.chkCliente);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.chkAuto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAuto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbVolver);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnLst);
            this.Controls.Add(this.dgv);
            this.Name = "frmlstReparaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Reparaciones";
            this.Load += new System.EventHandler(this.frmlstReparaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnLst;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVolver;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAuto;
        private System.Windows.Forms.CheckBox chkCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}