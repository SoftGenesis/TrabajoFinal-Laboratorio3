namespace TP1Lab3
{
    partial class frmAgregarRepar
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
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVolver = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRepuesto = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFalla = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReparacion = new System.Windows.Forms.TextBox();
            this.cmbPatente = new System.Windows.Forms.ComboBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnLstCmb = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(632, 487);
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
            "Agregar Repuesto",
            "--Listas--",
            "Lista de Autos",
            "Lista de Clientes",
            "Lista de Reparaciones",
            "Lista de Repuestos",
            "--Estadisticas--",
            "Grafico Autos"});
            this.cmbVolver.Location = new System.Drawing.Point(632, 538);
            this.cmbVolver.Name = "cmbVolver";
            this.cmbVolver.Size = new System.Drawing.Size(207, 30);
            this.cmbVolver.TabIndex = 66;
            // 
            // dtp
            // 
            this.dtp.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.dtp.Location = new System.Drawing.Point(560, 24);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(268, 22);
            this.dtp.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 23);
            this.label2.TabIndex = 63;
            this.label2.Text = "Nombre de Cliente";
            // 
            // cmbRepuesto
            // 
            this.cmbRepuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cmbRepuesto.FormattingEnabled = true;
            this.cmbRepuesto.Items.AddRange(new object[] {
            "--",
            "A conseguir"});
            this.cmbRepuesto.Location = new System.Drawing.Point(560, 120);
            this.cmbRepuesto.Name = "cmbRepuesto";
            this.cmbRepuesto.Size = new System.Drawing.Size(268, 30);
            this.cmbRepuesto.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(17, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 60;
            this.label6.Text = "Falla";
            // 
            // txtFalla
            // 
            this.txtFalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFalla.Location = new System.Drawing.Point(173, 115);
            this.txtFalla.Name = "txtFalla";
            this.txtFalla.Size = new System.Drawing.Size(208, 28);
            this.txtFalla.TabIndex = 59;
            this.txtFalla.TextChanged += new System.EventHandler(this.txtFalla_TextChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVolver.Location = new System.Drawing.Point(726, 568);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 44);
            this.btnVolver.TabIndex = 57;
            this.btnVolver.Text = "Ir/Salir";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAdd.Location = new System.Drawing.Point(457, 506);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 44);
            this.btnAdd.TabIndex = 56;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(33, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 23);
            this.label5.TabIndex = 55;
            this.label5.Text = "Seleccione Patente";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(424, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 54;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(424, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 53;
            this.label3.Text = "Repuesto";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 52;
            this.label1.Text = "Reparacion";
            // 
            // txtReparacion
            // 
            this.txtReparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtReparacion.Location = new System.Drawing.Point(173, 18);
            this.txtReparacion.Name = "txtReparacion";
            this.txtReparacion.Size = new System.Drawing.Size(208, 28);
            this.txtReparacion.TabIndex = 51;
            this.txtReparacion.TextChanged += new System.EventHandler(this.txtReparacion_TextChanged);
            // 
            // cmbPatente
            // 
            this.cmbPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cmbPatente.FormattingEnabled = true;
            this.cmbPatente.Location = new System.Drawing.Point(251, 108);
            this.cmbPatente.Name = "cmbPatente";
            this.cmbPatente.Size = new System.Drawing.Size(224, 30);
            this.cmbPatente.TabIndex = 68;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtCliente.Location = new System.Drawing.Point(251, 49);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(224, 28);
            this.txtCliente.TabIndex = 69;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // btnLstCmb
            // 
            this.btnLstCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLstCmb.ForeColor = System.Drawing.Color.Black;
            this.btnLstCmb.Location = new System.Drawing.Point(269, 144);
            this.btnLstCmb.Name = "btnLstCmb";
            this.btnLstCmb.Size = new System.Drawing.Size(180, 38);
            this.btnLstCmb.TabIndex = 71;
            this.btnLstCmb.Text = "Actualizar Patente";
            this.btnLstCmb.UseVisualStyleBackColor = true;
            this.btnLstCmb.Click += new System.EventHandler(this.btnLstCmb_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::TP1Lab3.Properties.Resources.Fondo_nebulosa_claro;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.btnLstCmb);
            this.groupBox1.Controls.Add(this.cmbPatente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(326, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 207);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese Datos de Cliente y Presione Actualizar Patente";
            // 
            // frmAgregarRepar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP1Lab3.Properties.Resources.ImagenTaller;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 613);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbVolver);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cmbRepuesto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFalla);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtReparacion);
            this.Name = "frmAgregarRepar";
            this.Text = "Agregar Reparaciones";
            this.Load += new System.EventHandler(this.frmAgregarRepar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVolver;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRepuesto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFalla;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReparacion;
        private System.Windows.Forms.ComboBox cmbPatente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnLstCmb;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}