namespace TP1Lab3
{
    partial class frmAgregarRepu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombreR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVolver = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVolver.Location = new System.Drawing.Point(746, 398);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 44);
            this.btnVolver.TabIndex = 40;
            this.btnVolver.Text = "Ir/Salir";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAdd.Location = new System.Drawing.Point(406, 288);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 44);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(402, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 31);
            this.label5.TabIndex = 38;
            this.label5.Text = "Valor Final Total";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(24, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 38);
            this.label4.TabIndex = 37;
            this.label4.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Nombre";
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtValorFinal.Location = new System.Drawing.Point(613, 34);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(219, 28);
            this.txtValorFinal.TabIndex = 34;
            this.txtValorFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorFinal.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCodigo.Location = new System.Drawing.Point(148, 113);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(219, 28);
            this.txtCodigo.TabIndex = 33;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNombreR
            // 
            this.txtNombreR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNombreR.Location = new System.Drawing.Point(148, 34);
            this.txtNombreR.Name = "txtNombreR";
            this.txtNombreR.Size = new System.Drawing.Size(203, 28);
            this.txtNombreR.TabIndex = 32;
            this.txtNombreR.TextChanged += new System.EventHandler(this.txtNombreR_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(402, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 28);
            this.label2.TabIndex = 43;
            this.label2.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCantidad.Location = new System.Drawing.Point(613, 113);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(219, 28);
            this.txtCantidad.TabIndex = 42;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(24, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 45;
            this.label3.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtMarca.Location = new System.Drawing.Point(148, 198);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(219, 28);
            this.txtMarca.TabIndex = 44;
            this.txtMarca.TextChanged += new System.EventHandler(this.txtMarca_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(652, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 48);
            this.label7.TabIndex = 52;
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
            "--Listas--",
            "Lista de Autos",
            "Lista de Clientes",
            "Lista de Reparaciones",
            "Lista de Repuestos",
            "--Estadisticas--",
            "Grafico Autos"});
            this.cmbVolver.Location = new System.Drawing.Point(652, 366);
            this.cmbVolver.Name = "cmbVolver";
            this.cmbVolver.Size = new System.Drawing.Size(207, 30);
            this.cmbVolver.TabIndex = 51;
            // 
            // frmAgregarRepu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP1Lab3.Properties.Resources.Repuestos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(866, 444);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbVolver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombreR);
            this.Name = "frmAgregarRepu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Repuesto";
            this.Load += new System.EventHandler(this.frmAgregarRepu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombreR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVolver;
    }
}