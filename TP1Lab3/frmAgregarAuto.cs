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
    public partial class frmAgregarAuto : Form
    {
        public frmAgregarAuto()
        {
            InitializeComponent();
        }
        clsAuto a = new clsAuto();
        clsClienteMain c = new clsClienteMain();

       private void btnAdd_Click(object sender, EventArgs e)
       {
            Int32 IdCliente = Convert.ToInt32(cmbCliente.SelectedValue);
            a.Patente = txtPatente.Text;
            a.Marca = cmbMarcasInternacional.Text;
            a.Modelo = txtModelo.Text;
            a.Año = Convert.ToInt32(txtAño.Text);
            a.Sino = cmbVigencia.Text;
            a.Idcliente = IdCliente;
            a.Agregar();
      
            MessageBox.Show("Auto almacenado con Exito!!");
            txtPatente.Text = "";
            txtModelo.Text = "";
            txtAño.Text = "";
            cmbCliente.SelectedIndex = 0;
            cmbVigencia.SelectedIndex = 0;
            cmbMarcasInternacional.SelectedIndex = 0;
       }

        private void frmAgregarAuto_Load(object sender, EventArgs e)
        {
            c.ListarCombo(cmbCliente);
            a.CargarCmbFrm(cmbMarcasInternacional);
        }
        private void txtPatente_TextChanged(object sender, EventArgs e)
        {
            if (txtAño.Text == "" && txtModelo.Text == "" && txtPatente.Text == "")
            {
                btnAdd.Enabled = false;
            }
            else 
            {
                btnAdd.Enabled = true;
            }
        }
        private void txtModelo_TextChanged(object sender, EventArgs e)
        {
            if (txtAño.Text == "" && txtModelo.Text == "" && txtPatente.Text == "")
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }
        private void txtMarca_TextChanged(object sender, EventArgs e)
        {
            if (txtAño.Text == "" && txtModelo.Text == "" && txtPatente.Text == "")
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }
        private void txtAño_TextChanged(object sender, EventArgs e)
        {
            if (txtAño.Text == "" && txtModelo.Text == "" && txtPatente.Text == "")
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
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
                    frmAgregarRepar frmAddRa = new frmAgregarRepar();
                    frmAddRa.ShowDialog();
                    this.Close();
                    break;
                case 3:
                    frmAgregarRepu frmAddRu = new frmAgregarRepu();
                    frmAddRu.ShowDialog();
                    this.Close();
                    break;
                case 5:
                    frmlstAutos frmlstA = new frmlstAutos();
                    frmlstA.ShowDialog();
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


    }
}
