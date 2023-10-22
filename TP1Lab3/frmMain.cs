using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace TP1Lab3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private SpeechRecognitionEngine escucha = new SpeechRecognitionEngine();
        String mensaje;

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCliente add = new frmAgregarCliente();
            add.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reconocimiento(object sender, SpeechRecognizedEventArgs e)
        {
            foreach (RecognizedWordUnit palabra in e.Result.Words)
            {
                if (palabra.Text == "Out" || palabra.Text == "Salir")
                {
                    Application.Exit();
                }
            }
        }
        private void btnEscuchar_Click(object sender, EventArgs e)
        {
            label1.Text = "Te escucho...";
            Choices lista = new Choices();
            lista.Add(new String[] { "Out", "Salir" });
            Grammar gramatica = new Grammar(new GrammarBuilder(lista));
            try
            {
                escucha.SetInputToDefaultAudioDevice();
                escucha.LoadGrammar(gramatica);
                escucha.SpeechRecognized += reconocimiento;
                escucha.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch (InvalidOperationException)
            {
                mensaje = "No se puede abrir mas de una vez";
                MessageBox.Show(mensaje, "Accion Erronea", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void agregarAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarAuto addCar = new frmAgregarAuto();
            addCar.ShowDialog();
        }

        private void agregarRepuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarRepu addRu = new frmAgregarRepu();
            addRu.ShowDialog(); 
        }

        private void agregarReparacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarRepar addRa = new frmAgregarRepar();
            addRa.ShowDialog();
        }

        private void listarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlstClientes lstC = new frmlstClientes();
            lstC.ShowDialog();
        }

        private void listarAutosPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlstAutos lstA = new frmlstAutos();
            lstA.ShowDialog();
        }

        private void listarRepuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlstRepuestos lstR = new frmlstRepuestos();
            lstR.ShowDialog();
        }

        private void listarReparacionesDeUnAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlstReparaciones lstR = new frmlstReparaciones();
            lstR.ShowDialog();
        }

        private void estadisticaPorMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrafico grphic = new frmGrafico();
            grphic.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe acercaDe = new frmAcercaDe();
            acercaDe.ShowDialog();
        }
    }
}
