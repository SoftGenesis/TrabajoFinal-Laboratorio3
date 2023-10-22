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
    public partial class frmlstAutos : Form
    {
        clsAuto a = new clsAuto();
        clsClienteMain c = new clsClienteMain();
        public frmlstAutos()
        {
            InitializeComponent();
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
                    frmlstClientes frmlstC = new frmlstClientes();
                    frmlstC.ShowDialog();
                    this.Close();
                    break;
                case 7:
                    frmlstReparaciones frmlstRa = new frmlstReparaciones();
                    frmlstRa.ShowDialog();
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
        private void btnLst_Click(object sender, EventArgs e)
        {
            if (chkCliente.Checked)
            {
                a.ListarCliente(dgv, cmbCliente);
            }
            else
            {
                if (chkMarca.Checked)
                {
                    a.ListarMarca(dgv, cmbMarca);
                }
                else 
                {
                    a.Listar(dgv);
                }
            }
        }

        private void chkCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCliente.Checked)
            {
                cmbCliente.Enabled = true;
                chkMarca.Enabled = false;
                cmbMarca.Enabled = false;
            }
            else 
            {
                chkMarca.Enabled = true;
                cmbMarca.Enabled = false;
                cmbCliente.Enabled = false;
            }
        }

        private void frmlstAutos_Load(object sender, EventArgs e)
        {
            a.ListarComboMarca(cmbMarca);
            c.ListarCombo(cmbCliente);
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Exportacion de Archivo: Seleccione Formato e Ingrese Nombre del Archivo";
            sfd.RestoreDirectory = true;
            sfd.Filter = "Archivo separado por coma|*.csv| Archivo de Texto|*.txt";
            sfd.ShowDialog();
            a.Exportar(sfd.FileName);
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMarca.Checked)
            {
                cmbMarca.Enabled = true;
                chkCliente.Enabled = false;
                cmbCliente.Enabled = false;
            }
            else 
            {
                chkCliente.Enabled = true;
                cmbMarca.Enabled = false;
                cmbCliente.Enabled = false;
            }
        }

        private void cmbVolver_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            prtDoc.PrinterSettings = prtVentana.PrinterSettings;
            prtDoc.Print();
        }

        private void prtDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            a.ImprimirAutos(e);
            MessageBox.Show("Impresion generada exitosamente!!");
        }
    }
}
