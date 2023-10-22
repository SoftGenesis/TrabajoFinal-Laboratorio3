namespace TP1Lab3
{
    partial class frmlstRepuestos
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
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVolver = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMarca = new System.Windows.Forms.CheckBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDoc = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExp
            // 
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnExp.Location = new System.Drawing.Point(551, 572);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(114, 44);
            this.btnExp.TabIndex = 50;
            this.btnExp.Text = "Exportar";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnLst
            // 
            this.btnLst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLst.Location = new System.Drawing.Point(349, 572);
            this.btnLst.Name = "btnLst";
            this.btnLst.Size = new System.Drawing.Size(114, 44);
            this.btnLst.TabIndex = 49;
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
            this.dgv.Location = new System.Drawing.Point(12, 132);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1111, 423);
            this.dgv.TabIndex = 48;
            // 
            // Propietario
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Propietario.DefaultCellStyle = dataGridViewCellStyle1;
            this.Propietario.HeaderText = "Nombre Repuesto";
            this.Propietario.MinimumWidth = 6;
            this.Propietario.Name = "Propietario";
            this.Propietario.Width = 150;
            // 
            // Column5
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column5.HeaderText = "Marca";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Codigo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column3
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Cantidad";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column2.HeaderText = "Valor Total Por Repuesto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column4
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "Valor por Unidad";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVolver.Location = new System.Drawing.Point(965, 679);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(182, 44);
            this.btnVolver.TabIndex = 57;
            this.btnVolver.Text = "Ir/Salir";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click_1);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(939, 594);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 48);
            this.label7.TabIndex = 67;
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
            "Lista de Reparaciones",
            "--Estadisticas--",
            "Grafico Autos"});
            this.cmbVolver.Location = new System.Drawing.Point(940, 645);
            this.cmbVolver.Name = "cmbVolver";
            this.cmbVolver.Size = new System.Drawing.Size(207, 30);
            this.cmbVolver.TabIndex = 66;
            // 
            // cmbMarca
            // 
            this.cmbMarca.Enabled = false;
            this.cmbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Items.AddRange(new object[] {
            "--"});
            this.cmbMarca.Location = new System.Drawing.Point(670, 41);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(207, 30);
            this.cmbMarca.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(208, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 48);
            this.label1.TabIndex = 69;
            this.label1.Text = "Seleccione Marca o Presione Listar";
            // 
            // chkMarca
            // 
            this.chkMarca.AutoSize = true;
            this.chkMarca.Location = new System.Drawing.Point(612, 50);
            this.chkMarca.Name = "chkMarca";
            this.chkMarca.Size = new System.Drawing.Size(18, 17);
            this.chkMarca.TabIndex = 70;
            this.chkMarca.UseVisualStyleBackColor = true;
            this.chkMarca.CheckedChanged += new System.EventHandler(this.chkMarca_CheckedChanged);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnImprimir.Location = new System.Drawing.Point(732, 572);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(114, 44);
            this.btnImprimir.TabIndex = 88;
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
            // frmlstRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP1Lab3.Properties.Resources.TallerMecanico;
            this.ClientSize = new System.Drawing.Size(1150, 725);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.chkMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbVolver);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnLst);
            this.Controls.Add(this.dgv);
            this.Name = "frmlstRepuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Repuestos";
            this.Load += new System.EventHandler(this.frmlstRepuestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnLst;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVolver;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMarca;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDoc;
    }
}