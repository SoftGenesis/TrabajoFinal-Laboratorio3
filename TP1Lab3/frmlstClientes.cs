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
    public partial class frmlstClientes : Form
    {
        clsClienteMain c = new clsClienteMain();
        public frmlstClientes()
        {
            InitializeComponent();
        }

        private void btnLst_Click(object sender, EventArgs e)
        {
            if (chkDeuda.Checked)
            {
                c.ListarDeu(dgv, lblCantidad, lblDeuda);
            }
            else
            {
                c.Listar(dgv, lblCantidad, lblDeuda);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)//Revisar
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

        private void btnExp_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Exportacion de Archivo: Seleccione Formato e Ingrese Nombre del Archivo";
            sfd.RestoreDirectory = true;
            sfd.Filter = "Archivo separado por coma|*.csv| Archivo de Texto|*.txt";
            sfd.ShowDialog();
            c.Exportar(sfd.FileName);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            prtDoc.PrinterSettings = prtVentana.PrinterSettings;
            prtDoc.Print();
        }

        private void prtDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            c.ImprimirClientes(e);
            MessageBox.Show("Impresion generada exitosamente!!");
        }

        private void chkDeuda_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
