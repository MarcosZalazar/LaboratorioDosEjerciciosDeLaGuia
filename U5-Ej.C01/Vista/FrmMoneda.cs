using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;

namespace Vista
{
    public partial class FrmMoneda : Form
    {
        public FrmMoneda()
        {
            InitializeComponent();
        }
        private void FrmMoneda_Load(object sender, EventArgs e)
        {
            txtCotizacionDolar.Text = "1";
            txtCotizacionDolar.Enabled = false;
            txtEuroAEuro.Enabled = false;
            txtEuroADolar.Enabled = false;
            txtEuroAPeso.Enabled = false;
            txtDolarAEuro.Enabled = false;
            txtDolarADolar.Enabled = false;
            txtDolarAPeso.Enabled = false;
            txtPesoAEuro.Enabled = false;
            txtPesoADolar.Enabled = false;
            txtPesoAPeso.Enabled = false;
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (this.btnLockCotizacion.ImageIndex == 0)
            {
                this.btnLockCotizacion.ImageIndex++;
                this.txtCotizacionEuro.Enabled = false;
                this.txtCotizacionPeso.Enabled = false;
            }
            else 
            {
                this.btnLockCotizacion.ImageIndex = 0;
                this.txtCotizacionEuro.Enabled = true;
                this.txtCotizacionPeso.Enabled = true;
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double dineroEnEuros;

            if (!String.IsNullOrWhiteSpace(txtEuro.Text))
            {
                if (Double.TryParse(txtEuro.Text, out dineroEnEuros))
                {
                    Euro eurosAConvertir = new Euro(dineroEnEuros);
                    txtEuroAEuro.Text = eurosAConvertir.GetCantidad().ToString();
                    txtEuroADolar.Text = ((Dolar)eurosAConvertir).GetCantidad().ToString();
                    txtEuroAPeso.Text = ((Peso)eurosAConvertir).GetCantidad().ToString();
                }
            }
            else
            {
                txtEuro.Focus();
                MessageBox.Show("Suma incorrecta, ingresela nuevamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double dineroEnDolares;

            if (!String.IsNullOrWhiteSpace(txtDolar.Text))
            {
                if (Double.TryParse(txtDolar.Text, out dineroEnDolares))
                {
                    Dolar dolaresAConvertir = new Dolar(dineroEnDolares);
                    txtDolarADolar.Text = dolaresAConvertir.GetCantidad().ToString();
                    txtDolarAEuro.Text = ((Euro)dolaresAConvertir).GetCantidad().ToString();
                    txtDolarAPeso.Text = ((Peso)dolaresAConvertir).GetCantidad().ToString();
                }
            }
            else
            {
                txtDolar.Focus();
                MessageBox.Show("Suma incorrecta, ingresela nuevamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double dineroEnPesos;

            if (!String.IsNullOrWhiteSpace(txtPeso.Text))
            {
                if (Double.TryParse(txtPeso.Text, out dineroEnPesos))
                {
                    Peso pesosAConvertir = new Peso(dineroEnPesos);
                    txtPesoAPeso.Text = pesosAConvertir.GetCantidad().ToString();
                    txtPesoAEuro.Text = ((Euro)pesosAConvertir).GetCantidad().ToString();
                    txtPesoADolar.Text = ((Dolar)pesosAConvertir).GetCantidad().ToString();
                }
            }
            else
            {
                txtDolar.Focus();
                MessageBox.Show("Suma incorrecta, ingresela nuevamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double cotizEuro;

            if (!String.IsNullOrWhiteSpace(txtCotizacionEuro.Text))
            {
                if (Double.TryParse(txtCotizacionEuro.Text, out cotizEuro))
                {
                    Euro.SetCotizacion(cotizEuro);
                }
            }
            else
            {
                txtCotizacionEuro.Focus();
                MessageBox.Show("Cotización incorrecta, ingresela nuevamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            double cotizPeso;

            if (!String.IsNullOrWhiteSpace(txtCotizacionPeso.Text))
            {
                if (Double.TryParse(txtCotizacionPeso.Text, out cotizPeso))
                {
                    Euro.SetCotizacion(cotizPeso);
                }
            }
            else
            {
                txtCotizacionPeso.Focus();
                MessageBox.Show("Cotización incorrecta, ingresela nuevamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
