using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1Lab3
{
    public partial class frmlstReparaciones : Form
    {
        clsReparacion ra = new clsReparacion();
        clsAuto a = new clsAuto();
        clsClienteMain c = new clsClienteMain();
        public frmlstReparaciones()
        {
            InitializeComponent();
        }

        private void btnLst_Click(object sender, EventArgs e)
        {
            if (chkAuto.Checked)
            {
                ra.ListarA(dgv, cmbAuto);
                
            }
            else if (chkCliente.Checked)
            {
                ra.ListarC(dgv, cmbCliente);
            }
            else if(!chkAuto.Checked && !chkCliente.Checked)
            {
                ra.Listar(dgv);
            }
        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            switch (cmbVolver.SelectedIndex)
            {
                case 1:
                    frmAgregarCliente frmAddC = new frmAgregarCliente();
                    frmAddC.ShowDialog();
                    this.Close();
                    break;
                case 2:
                    frmAgregarAuto frmAddA = new frmAgregarAuto();
                    frmAddA.ShowDialog();
                    this.Close();
                    break;
                case 3:
                    frmAgregarRepar frmAddRa = new frmAgregarRepar();
                    frmAddRa.ShowDialog();
                    this.Close();
                    break;
                case 4:
                    frmAgregarRepu frmAddRu = new frmAgregarRepu();
                    frmAddRu.ShowDialog();
                    this.Close();
                    break;
                case 6:
                    frmlstAutos frmlstA = new frmlstAutos();
                    frmlstA.ShowDialog();
                    this.Close();
                    break;
                case 7:
                    frmlstClientes frmlstC = new frmlstClientes();
                    frmlstC.ShowDialog();
                    this.Close();
                    break;
                case 8:
                    frmlstRepuestos frmlstRu = new frmlstRepuestos();
                    frmlstRu.ShowDialog();
                    this.Close();
                    break;
                case 10:
                    frmGrafico graphic = new frmGrafico();
                    graphic.ShowDialog();
                    this.Close();
                    break;
                default:
                    this.Close();
                    break;
            }
            cmbVolver.SelectedIndex = 0;
        }
        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAuto.Checked)
            {
                cmbAuto.Enabled = true;
                cmbCliente.Enabled = false;
                chkCliente.Enabled = false;
            }
            else 
            {
                cmbAuto.Enabled = false;
                chkCliente.Enabled = true;
            }
        }
        private void chkCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCliente.Checked)
            {
                cmbCliente.Enabled = true;
                cmbAuto.Enabled = false;
                chkAuto.Enabled = false;
            }
            else
            {
                cmbCliente.Enabled = false;
                chkAuto.Enabled = true;
            }
        }
        private void frmlstReparaciones_Load(object sender, EventArgs e)
        {
            a.ListarComboPatente(cmbAuto);
            c.ListarCombo(cmbCliente);
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Exportacion de Archivo: Seleccione Formato e Ingrese Nombre del Archivo";
            sfd.RestoreDirectory = true;
            sfd.Filter = "Archivo separado por coma|*.csv| Archivo de Texto|*.txt";
            sfd.ShowDialog();
            ra.Exportar(sfd.FileName);
        }

        private void prtDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ra.ImprimirReparaciones(e);
            MessageBox.Show("Impresion generada exitosamente!!");

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            prtDoc.PrinterSettings = prtVentana.PrinterSettings;
            prtDoc.Print();
        }
    }
}
