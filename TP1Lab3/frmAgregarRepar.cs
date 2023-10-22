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
    public partial class frmAgregarRepar : Form
    {
        public frmAgregarRepar()
        {
            InitializeComponent();
        }
        clsClienteMain c = new clsClienteMain();
        clsRepuesto ru = new clsRepuesto();
        clsReparacion ra = new clsReparacion();
        clsAuto a = new clsAuto();
        String mensaje;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String IdPatente = a.GetIdPatente(cmbPatente.Text);
            String IdCliente = c.GetIdCliente(txtCliente.Text);
            ra.Reparacion = txtReparacion.Text;
            ra.Fecha = dtp.Value;
            ra.Falla = txtFalla.Text;
            ra.Idrepuesto = Convert.ToInt32(cmbRepuesto.SelectedValue);
            ra.Idpatente = Convert.ToInt32(IdPatente);
            ra.Idcliente = Convert.ToInt32(IdCliente);
                //Convert.ToInt32(cmbCliente.SelectedValue);
            ra.Agregar();
            
            MessageBox.Show("Reparacion almacenada con Exito!!");
            txtReparacion.Text = "";
            txtFalla.Text = "";
            cmbRepuesto.SelectedIndex = 0;
            cmbPatente.SelectedIndex = 0;
            txtCliente.Text = "";
        }

        private void frmAgregarRepar_Load(object sender, EventArgs e)
        {
            txtCliente.AutoCompleteCustomSource = c.CargarDatosTxt();
            txtCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;
            ru.ListarCombo(cmbRepuesto);
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

        private void txtReparacion_TextChanged(object sender, EventArgs e)
        {
            if (txtReparacion.Text != "" && txtFalla.Text != "" && txtCliente.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else 
            {
                btnAdd.Enabled = false;
            }

        }

        private void txtFalla_TextChanged(object sender, EventArgs e)
        {
            if (txtReparacion.Text != "" && txtFalla.Text != "" && txtCliente.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void btnLstCmb_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                cmbPatente.Text = "--";
                mensaje = "Ingrese el Nombre Completo del Cliente Por Favor!!";
                MessageBox.Show(mensaje, "Accion Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {
                a.ListarComboPatenteCondicionado(cmbPatente, txtCliente);
            }
            
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtReparacion.Text != "" && txtFalla.Text != "" && txtCliente.Text != "")
            {
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }
    }
}
