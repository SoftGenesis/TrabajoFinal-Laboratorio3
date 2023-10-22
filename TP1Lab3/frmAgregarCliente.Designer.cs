namespace TP1Lab3
{
    partial class frmAgregarCliente
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVolver = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtName.Location = new System.Drawing.Point(157, 51);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 28);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAddress.Location = new System.Drawing.Point(542, 143);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(219, 28);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtMail.Location = new System.Drawing.Point(542, 51);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(219, 28);
            this.txtMail.TabIndex = 3;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPhone.Location = new System.Drawing.Point(184, 141);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(181, 28);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpDate.Location = new System.Drawing.Point(288, 275);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(307, 28);
            this.dtpDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Propietaria";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(153, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha ";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(408, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(408, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 57);
            this.label5.TabIndex = 10;
            this.label5.Text = "Telefono (Sin Característica)";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAdd.Location = new System.Drawing.Point(336, 390);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 44);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVolver.Location = new System.Drawing.Point(691, 437);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(114, 44);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "Ir/Salir";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(28, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Deuda";
            // 
            // txtDeuda
            // 
            this.txtDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtDeuda.Location = new System.Drawing.Point(157, 224);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(208, 28);
            this.txtDeuda.TabIndex = 14;
            this.txtDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDeuda.TextChanged += new System.EventHandler(this.txtDeuda_TextChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(598, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 48);
            this.label7.TabIndex = 34;
            this.label7.Text = "Seleccione Ventana o Presione Salir";
            // 
            // cmbVolver
            // 
            this.cmbVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.cmbVolver.FormattingEnabled = true;
            this.cmbVolver.Items.AddRange(new object[] {
            " --Agregados--",
            "Agregar Auto",
            "Agregar Reparación",
            "Agregar Repuesto",
            "--Listas--",
            "Lista de Autos",
            "Lista de Clientes",
            "Lista de Reparaciones",
            "Lista de Repuestos",
            "--Estadisticas--",
            "Grafico Autos"});
            this.cmbVolver.Location = new System.Drawing.Point(598, 398);
            this.cmbVolver.Name = "cmbVolver";
            this.cmbVolver.Size = new System.Drawing.Size(207, 30);
            this.cmbVolver.TabIndex = 16;
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP1Lab3.Properties.Resources.LogoEstetico;
            this.ClientSize = new System.Drawing.Size(823, 491);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbVolver);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDeuda);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Name = "frmAgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cliente";
            this.Load += new System.EventHandler(this.frmAgregarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbVolver;
    }
}