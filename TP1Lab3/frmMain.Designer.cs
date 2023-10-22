namespace TP1Lab3
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.agregarAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarAutosPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticaPorMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.agregarRepuestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarRepuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.agregarReparacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarReparacionesDeUnAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEscuchar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::TP1Lab3.Properties.Resources.loto_peque;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.operacionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1225, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.listarClientesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.agregarAutoToolStripMenuItem,
            this.listarAutosPorClienteToolStripMenuItem,
            this.estadisticaPorMarcaToolStripMenuItem,
            this.toolStripMenuItem3,
            this.agregarRepuestoToolStripMenuItem,
            this.listarRepuestosToolStripMenuItem,
            this.toolStripMenuItem4,
            this.agregarReparacionToolStripMenuItem,
            this.listarReparacionesDeUnAutoToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(125, 29);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.agregarClienteToolStripMenuItem.Text = "Agregar Cliente...";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // listarClientesToolStripMenuItem
            // 
            this.listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            this.listarClientesToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.listarClientesToolStripMenuItem.Text = "Listar Clientes...";
            this.listarClientesToolStripMenuItem.Click += new System.EventHandler(this.listarClientesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(263, 6);
            // 
            // agregarAutoToolStripMenuItem
            // 
            this.agregarAutoToolStripMenuItem.Name = "agregarAutoToolStripMenuItem";
            this.agregarAutoToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.agregarAutoToolStripMenuItem.Text = "Agregar Auto...";
            this.agregarAutoToolStripMenuItem.Click += new System.EventHandler(this.agregarAutoToolStripMenuItem_Click);
            // 
            // listarAutosPorClienteToolStripMenuItem
            // 
            this.listarAutosPorClienteToolStripMenuItem.Name = "listarAutosPorClienteToolStripMenuItem";
            this.listarAutosPorClienteToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.listarAutosPorClienteToolStripMenuItem.Text = "Listar Autos...";
            this.listarAutosPorClienteToolStripMenuItem.Click += new System.EventHandler(this.listarAutosPorClienteToolStripMenuItem_Click);
            // 
            // estadisticaPorMarcaToolStripMenuItem
            // 
            this.estadisticaPorMarcaToolStripMenuItem.Name = "estadisticaPorMarcaToolStripMenuItem";
            this.estadisticaPorMarcaToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.estadisticaPorMarcaToolStripMenuItem.Text = "Estadistica Por Marca";
            this.estadisticaPorMarcaToolStripMenuItem.Click += new System.EventHandler(this.estadisticaPorMarcaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(263, 6);
            // 
            // agregarRepuestoToolStripMenuItem
            // 
            this.agregarRepuestoToolStripMenuItem.Name = "agregarRepuestoToolStripMenuItem";
            this.agregarRepuestoToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.agregarRepuestoToolStripMenuItem.Text = "Agregar Repuesto...";
            this.agregarRepuestoToolStripMenuItem.Click += new System.EventHandler(this.agregarRepuestoToolStripMenuItem_Click);
            // 
            // listarRepuestosToolStripMenuItem
            // 
            this.listarRepuestosToolStripMenuItem.Name = "listarRepuestosToolStripMenuItem";
            this.listarRepuestosToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.listarRepuestosToolStripMenuItem.Text = "Listar Repuestos...";
            this.listarRepuestosToolStripMenuItem.Click += new System.EventHandler(this.listarRepuestosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(263, 6);
            // 
            // agregarReparacionToolStripMenuItem
            // 
            this.agregarReparacionToolStripMenuItem.Name = "agregarReparacionToolStripMenuItem";
            this.agregarReparacionToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.agregarReparacionToolStripMenuItem.Text = "Agregar Reparacion...";
            this.agregarReparacionToolStripMenuItem.Click += new System.EventHandler(this.agregarReparacionToolStripMenuItem_Click);
            // 
            // listarReparacionesDeUnAutoToolStripMenuItem
            // 
            this.listarReparacionesDeUnAutoToolStripMenuItem.Name = "listarReparacionesDeUnAutoToolStripMenuItem";
            this.listarReparacionesDeUnAutoToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
            this.listarReparacionesDeUnAutoToolStripMenuItem.Text = "Listar Reparaciones...";
            this.listarReparacionesDeUnAutoToolStripMenuItem.Click += new System.EventHandler(this.listarReparacionesDeUnAutoToolStripMenuItem_Click);
            // 
            // btnEscuchar
            // 
            this.btnEscuchar.BackgroundImage = global::TP1Lab3.Properties.Resources.ParlanteButton;
            this.btnEscuchar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEscuchar.Location = new System.Drawing.Point(58, 786);
            this.btnEscuchar.Name = "btnEscuchar";
            this.btnEscuchar.Size = new System.Drawing.Size(110, 61);
            this.btnEscuchar.TabIndex = 1;
            this.btnEscuchar.UseVisualStyleBackColor = true;
            this.btnEscuchar.Click += new System.EventHandler(this.btnEscuchar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 758);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Presione el Boton y diga Salir";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TP1Lab3.Properties.Resources.TallerMecanico;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1225, 859);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEscuchar);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Seleccione Opcion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem agregarAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarAutosPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem agregarRepuestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarRepuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem agregarReparacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarReparacionesDeUnAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaPorMarcaToolStripMenuItem;
        private System.Windows.Forms.Button btnEscuchar;
        private System.Windows.Forms.Label label1;
    }
}

