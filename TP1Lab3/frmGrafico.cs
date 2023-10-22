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
    public partial class frmGrafico : Form
    {
        //clsGrafico g = new clsGrafico();
        clsAuto a = new clsAuto();
        public frmGrafico()
        {
            InitializeComponent();
        }

        private void btnCharge_Click(object sender, EventArgs e)
        {
            label1.Text = a.CantidadPorMarca(label5.Text);
            chart1.Titles.Add("Estadistica de Ingresos de Coches Por Marca en un Rango de Años");
            Int32 Am = Convert.ToInt32(txtAMenor.Text);
            Int32 AM = Convert.ToInt32(txtAMayor.Text);

            a.Estadistica(chart1,Am, AM);
            //textBox1.Text = "";
            label1.Text = "";
        }

        private void frmGrafico_Load(object sender, EventArgs e)
        {
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

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
                    frmlstAutos frmlstA = new frmlstAutos();
                    frmlstA.ShowDialog();
                    this.Close();
                    break;
                case 8:
                    frmlstReparaciones frmlstRa = new frmlstReparaciones();
                    frmlstRa.ShowDialog();
                    this.Close();
                    break;
                case 9:
                    frmlstRepuestos frmlstRu = new frmlstRepuestos();
                    frmlstRu.ShowDialog();
                    this.Close();
                    break;
                default:
                    this.Close();
                    break;
            }
            cmbVolver.SelectedIndex = 0;
        }

        private void cmbVolver_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtAMenor_TextChanged(object sender, EventArgs e)
        {
            if (txtAMenor.Text != "" && txtAMayor.Text != "")
            {
                btnCharge.Enabled = true;
            }
            else
            {
                btnCharge.Enabled = false;
            }
        }

        private void txtAMayor_TextChanged(object sender, EventArgs e)
        {
            if (txtAMenor.Text != "" && txtAMayor.Text != "")
            {
                btnCharge.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                btnCharge.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a.ImprimirGrafico(chart1, txtAMenor, txtAMayor);
        }
    }
}
