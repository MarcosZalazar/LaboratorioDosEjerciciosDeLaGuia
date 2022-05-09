using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaBiblioteca;

namespace WinForms
{
    public partial class FrmLlamador : Form
    {
        public Centralita frmCentralita;
        public FrmLlamador(Centralita c)
        {
            InitializeComponent();
            this.frmCentralita = c; 
        }

        public Centralita ExponerCentalita
        {
            get
            {
                return this.frmCentralita;
            }
        }
        private void btnNroUno_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "1";
        }

        private void btnNroDos_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "2";
        }

        private void btnNroTres_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "3";
        }

        private void btnNroCuatro_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "4";
        }

        private void btnNroCinco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "5";
        }

        private void btnNroSeis_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "6";
        }

        private void btnNroSiete_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "7";
        }

        private void btnNroOcho_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "8";
        }

        private void btnNroNueve_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "9";
        }

        private void btnNroCero_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "0";
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "*";
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text += "#";
            if (txtNroDestino.Text.StartsWith("#") == true)
            {
                cmbFranja.Enabled = true;
                // Carga
                cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
                // Lectura
                Provincial.Franja franjas;
                Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);

            }
            else
            {
                cmbFranja.Enabled = false;
            }
        }
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random duracionRandom =new Random();
            float duracionLlamada;
            Random costoRandom = new Random();
            float costoLlamada=0.0f;

            if (!string.IsNullOrEmpty(txtNroDestino.Text) && !string.IsNullOrEmpty(txtNroOrigen.Text))
            {
                duracionLlamada = duracionRandom.Next(1,51);
                if (txtNroDestino.Text.StartsWith('#'))
                {
                    Provincial llamadaProvincial = new Provincial(txtNroOrigen.Text,(Provincial.Franja)cmbFranja.SelectedIndex,duracionLlamada,txtNroDestino.Text);
                    this.frmCentralita = frmCentralita + llamadaProvincial;
                }
                else
                {
                    costoLlamada = costoRandom.Next((5)/10,(57)/10);
                    Local llamadaLocal = new Local(txtNroOrigen.Text, duracionLlamada, txtNroDestino.Text, costoLlamada);
                    this.frmCentralita = frmCentralita + llamadaLocal;
                }
            }
            btnLimpiar_Click(sender,e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Clear();
            this.txtNroDestino.Clear();
            cmbFranja.Enabled = false;
            this.cmbFranja.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            txtNroOrigen.Text = "1531025698";
            this.btnLimpiar_Click(sender,e);
        }
    }
}
