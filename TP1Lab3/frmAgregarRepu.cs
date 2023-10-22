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
    public partial class frmAgregarRepu : Form
    {
        clsRepuesto ru = new clsRepuesto();
        public frmAgregarRepu()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ru.NombreR = txtNombreR.Text;
            ru.CodigoR = txtCodigo.Text;
            ru.ValorFinalTotal = Convert.ToDecimal(txtValorFinal.Text);
            ru.Cantidad = Convert.ToInt32(txtCantidad.Text);
            ru.Marca = txtMarca.Text;
            ru.Agregar();

            MessageBox.Show("Repuesto almacenado con Exito!!");
            txtNombreR.Text = "";
            txtValorFinal.Text = "";
            txtCodigo.Text = "";
            txtCantidad.Text = "";
            txtMarca.Text = "";
        }

        private void txtNombreR_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreR.Text == "" && txtValorFinal.Text == "" && txtCodigo.Text
                == "" && txtCantidad.Text == "" && txtMarca.Text == "")
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreR.Text == "" && txtValorFinal.Text == "" && txtCodigo.Text == "" 
                && txtCantidad.Text == "" && txtMarca.Text == "")
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreR.Text == "" && txtValorFinal.Text == "" && txtCodigo.Text == "" 
                && txtCantidad.Text == "" && txtMarca.Text == "")
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
                    frmAgregarAuto frmAddA = new frmAgregarAuto();
                    frmAddA.ShowDialog();
                    this.Close();
                    break;
                case 3:
                    frmAgregarRepar frmAddRa = new frmAgregarRepar();
                    frmAddRa.ShowDialog();
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
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreR.Text == "" && txtValorFinal.Text == "" && txtCodigo.Text == "" 
                && txtCantidad.Text == "" && txtMarca.Text == "")
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
            if (txtNombreR.Text == "" && txtValorFinal.Text == "" && txtCodigo.Text == ""
                && txtCantidad.Text == "" && txtMarca.Text == "")
            {
                btnAdd.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = true;
            }
        }

        private void frmAgregarRepu_Load(object sender, EventArgs e)
        {

        }
    }
}
