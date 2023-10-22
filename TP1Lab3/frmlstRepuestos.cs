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
    public partial class frmlstRepuestos : Form
    {
        clsRepuesto ru = new clsRepuesto();
        public frmlstRepuestos()
        {
            InitializeComponent();
        }
        private void frmlstRepuestos_Load(object sender, EventArgs e)
        {
            ru.ListarComboMa(cmbMarca);
        }


        private void btnLst_Click(object sender, EventArgs e)
        {
           if (chkMarca.Checked)
           {
                ru.ListarMa(dgv, cmbMarca);
           }
           else 
           {
                ru.Listar(dgv);
           }
        }

        private void chkMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMarca.Checked)
            {
                cmbMarca.Enabled = true;
            }
            else 
            {
                cmbMarca.Enabled = false;
            }
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
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
                    frmlstReparaciones frmlstRa = new frmlstReparaciones();
                    frmlstRa.ShowDialog();
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
            ru.Exportar(sfd.FileName);
        }

        private void prtDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ru.ImprimirRepuestos(e);
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
