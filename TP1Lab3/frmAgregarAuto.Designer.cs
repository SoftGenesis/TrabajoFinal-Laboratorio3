namespace TP1Lab3
{
    partial class frmAgregarAuto
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cmbVigencia = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVolver = new System.Windows.Forms.ComboBox();
            this.cmbMarcasInternacional = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVolver.Location = new System.Drawing.Point(783, 412);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 44);
            this.btnVolver.TabIndex = 25;
            this.btnVolver.Text = "Ir/Salir";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAdd.Location = new System.Drawing.Point(420, 333);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 44);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(502, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Año";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(502, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(29, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 55);
            this.label3.TabIndex = 21;
            this.label3.Text = "Repuestos Vigentes";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Patente";
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAño.Location = new System.Drawing.Point(631, 123);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(208, 28);
            this.txtAño.TabIndex = 17;
            this.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAño.TextChanged += new System.EventHandler(this.txtAño_TextChanged);
            // 
            // txtPatente
            // 
            this.txtPatente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPatente.Location = new System.Drawing.Point(216, 24);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(208, 28);
            this.txtPatente.TabIndex = 14;
            this.txtPatente.TextChanged += new System.EventHandler(this.txtPatente_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(29, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtModelo.Location = new System.Drawing.Point(216, 121);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(208, 28);
            this.txtModelo.TabIndex = 27;
            this.txtModelo.TextChanged += new System.EventHandler(this.txtModelo_TextChanged);
            // 
            // cmbVigencia
            // 
            this.cmbVigencia.FormattingEnabled = true;
            this.cmbVigencia.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cmbVigencia.Location = new System.Drawing.Point(216, 218);
            this.cmbVigencia.Name = "cmbVigencia";
            this.cmbVigencia.Size = new System.Drawing.Size(208, 24);
            this.cmbVigencia.TabIndex = 29;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(631, 217);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(224, 24);
            this.cmbCliente.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(502, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Cliente";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(690, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 48);
            this.label7.TabIndex = 33;
            this.label7.Text = "Seleccione Ventana o Presione Salir";
            // 
            // cmbVolver
            // 
            this.cmbVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cmbVolver.FormattingEnabled = true;
            this.cmbVolver.Items.AddRange(new object[] {
            " --Agregados--",
            "Agregar Cliente",
            "Agregar Reparación",
            "Agregar Repuesto",
            "--Listas--",
            "Lista de Autos",
            "Lista de Clientes",
            "Lista de Reparaciones",
            "Lista de Repuestos",
            "--Estadisticas--",
            "Grafico Autos"});
            this.cmbVolver.Location = new System.Drawing.Point(690, 382);
            this.cmbVolver.Name = "cmbVolver";
            this.cmbVolver.Size = new System.Drawing.Size(207, 30);
            this.cmbVolver.TabIndex = 32;
            // 
            // cmbMarcasInternacional
            // 
            this.cmbMarcasInternacional.FormattingEnabled = true;
            this.cmbMarcasInternacional.Location = new System.Drawing.Point(631, 31);
            this.cmbMarcasInternacional.Name = "cmbMarcasInternacional";
            this.cmbMarcasInternacional.Size = new System.Drawing.Size(224, 24);
            this.cmbMarcasInternacional.TabIndex = 34;
            // 
            // frmAgregarAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP1Lab3.Properties.Resources.LogoFuego;
            this.ClientSize = new System.Drawing.Size(922, 470);
            this.Controls.Add(this.cmbMarcasInternacional);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.cmbVigencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtPatente);
            this.Name = "frmAgregarAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Automóvil";
            this.Load += new System.EventHandler(this.frmAgregarAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cmbVigencia;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVolver;
        private System.Windows.Forms.ComboBox cmbMarcasInternacional;
    }
}