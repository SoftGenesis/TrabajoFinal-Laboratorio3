namespace TP1Lab3
{
    partial class frmlstClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnExp = new System.Windows.Forms.Button();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVolver = new System.Windows.Forms.ComboBox();
            this.chkDeuda = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.prtDoc = new System.Drawing.Printing.PrintDocument();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
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
            this.dgv.Location = new System.Drawing.Point(12, 133);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1127, 458);
            this.dgv.TabIndex = 0;
            // 
            // Propietario
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Propietario.DefaultCellStyle = dataGridViewCellStyle13;
            this.Propietario.HeaderText = "Propietario";
            this.Propietario.MinimumWidth = 6;
            this.Propietario.Name = "Propietario";
            this.Propietario.Width = 125;
            // 
            // Column1
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column1.HeaderText = "Telefono";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column2.HeaderText = "Direccion";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle16;
            this.Column3.HeaderText = "Mail";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle17;
            this.Column4.HeaderText = "Fecha";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle18;
            this.Column5.HeaderText = "Deuda";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // btnLst
            // 
            this.btnLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLst.Location = new System.Drawing.Point(495, 627);
            this.btnLst.Name = "btnLst";
            this.btnLst.Size = new System.Drawing.Size(114, 44);
            this.btnLst.TabIndex = 40;
            this.btnLst.Text = "Listar";
            this.btnLst.UseVisualStyleBackColor = true;
            this.btnLst.Click += new System.EventHandler(this.btnLst_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(43, 604);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Cantidad de Clientes";
            // 
            // lblCantidad
            // 
            this.lblCantidad.BackColor = System.Drawing.Color.White;
            this.lblCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCantidad.Location = new System.Drawing.Point(294, 604);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(165, 23);
            this.lblCantidad.TabIndex = 42;
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnExp.Location = new System.Drawing.Point(651, 627);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(114, 44);
            this.btnExp.TabIndex = 43;
            this.btnExp.Text = "Exportar";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // lblDeuda
            // 
            this.lblDeuda.BackColor = System.Drawing.Color.White;
            this.lblDeuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblDeuda.Location = new System.Drawing.Point(294, 658);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(165, 23);
            this.lblDeuda.TabIndex = 45;
            this.lblDeuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(43, 658);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 23);
            this.label4.TabIndex = 44;
            this.label4.Text = "Total de Deuda";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVolver.Location = new System.Drawing.Point(966, 696);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(182, 44);
            this.btnVolver.TabIndex = 46;
            this.btnVolver.Text = "Ir/Salir";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(940, 614);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 48);
            this.label7.TabIndex = 63;
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
            "Lista de Reparaciones",
            "Lista de Repuestos",
            "--Estadisticas--",
            "Grafico Autos"});
            this.cmbVolver.Location = new System.Drawing.Point(940, 665);
            this.cmbVolver.Name = "cmbVolver";
            this.cmbVolver.Size = new System.Drawing.Size(207, 30);
            this.cmbVolver.TabIndex = 62;
            // 
            // chkDeuda
            // 
            this.chkDeuda.AutoSize = true;
            this.chkDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.chkDeuda.Location = new System.Drawing.Point(495, 48);
            this.chkDeuda.Name = "chkDeuda";
            this.chkDeuda.Size = new System.Drawing.Size(301, 26);
            this.chkDeuda.TabIndex = 73;
            this.chkDeuda.Text = "Sólo Listar Propietarios Deudores";
            this.chkDeuda.UseVisualStyleBackColor = true;
            this.chkDeuda.CheckedChanged += new System.EventHandler(this.chkDeuda_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label2.Location = new System.Drawing.Point(47, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 26);
            this.label2.TabIndex = 72;
            this.label2.Text = "Presione Listar o Indique Condición de Listado";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnImprimir.Location = new System.Drawing.Point(798, 627);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(114, 44);
            this.btnImprimir.TabIndex = 74;
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
            // frmlstClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP1Lab3.Properties.Resources.TallerMecanico;
            this.ClientSize = new System.Drawing.Size(1151, 743);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.chkDeuda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbVolver);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLst);
            this.Controls.Add(this.dgv);
            this.Name = "frmlstClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnLst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVolver;
        private System.Windows.Forms.CheckBox chkDeuda;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument prtDoc;
        private System.Windows.Forms.PrintDialog prtVentana;
    }
}