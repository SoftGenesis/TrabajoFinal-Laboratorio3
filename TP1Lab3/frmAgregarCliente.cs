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
    public partial class frmAgregarCliente : Form
    {
        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        clsClienteMain c = new clsClienteMain();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c.Nombre = txtName.Text;
            c.Telefono = Convert.ToInt32(txtPhone.Text);
            c.Direccion = txtAddress.Text;
            c.Mail = txtMail.Text;
            c.Fecha = dtpDate.Value;
            c.Deuda = Convert.ToDecimal(txtDeuda.Text);
            c.Agregar();

            MessageBox.Show("Dato almacenado Correctamente!!");
            txtAddress.Text = "";
            txtName.Text = "";
            txtMail.Text = "";
            txtPhone.Text = "";
            txtDeuda.Text = "";
        }
        public void Enable() 
        {
            if (txtAddress.Text == "" && txtName.Text == "" &&
            txtMail.Text == "" &&
            txtPhone.Text == "" && txtDeuda.Text == "")
            {
                btnAdd.Enabled = false;
            }
            else 
            {
                btnAdd.Enabled = true;
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Enable();
        }
        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            Enable();
        }
        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            Enable();
        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            Enable();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            switch (cmbVolver.SelectedIndex)
                {
                case 1:
                    frmAgregarAuto frmAddA = new frmAgregarAuto();
                    frmAddA.ShowDialog();
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
        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            Enable();
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
        }
    }
}
