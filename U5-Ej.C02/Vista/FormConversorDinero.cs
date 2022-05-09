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
    public partial class FormConversorDinero : Form
    {
        public FormConversorDinero()
        {
            InitializeComponent();
        }

        private void btnFahrToAll_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtFahrenheit.Text))
            {
                MessageBox.Show("Ingrese un valor","Atención",MessageBoxButtons.OK);
            }
            else 
            {
                double auxFahrToFah;
                if (double.TryParse(this.txtFahrenheit.Text, out auxFahrToFah))
                {
                    Fahrenheit gradFahrenheit =new Fahrenheit(auxFahrToFah);
                    this.txtRdoFahrToFahr.Text = gradFahrenheit.TemperaturaFahrenheit.ToString();
                    this.txtRdoFahrToCel.Text = ((Celsius)gradFahrenheit).TemperaturaCelcius.ToString();
                    this.txtRdoFahrToKel.Text = ((Kelvin)gradFahrenheit).TemperaturaKelvin.ToString();
                }
                else 
                {
                    MessageBox.Show("Dato inválido, ingrese un número", "Atención", MessageBoxButtons.OK);
                }  
            }
        }
        private void btnCelToAll_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtCelsius.Text))
            {
                MessageBox.Show("Ingrese un valor", "Atención", MessageBoxButtons.OK);
            }
            else
            {
                double auxCelToCel;
                if (double.TryParse(this.txtCelsius.Text, out auxCelToCel))
                {
                    Celsius gradCelsius = new Celsius(auxCelToCel);
                    this.txtRdoCelToCel.Text = gradCelsius.TemperaturaCelcius.ToString();
                    this.txtRdoCelToFahr.Text = ((Fahrenheit)gradCelsius).TemperaturaFahrenheit.ToString();
                    this.txtRdoCelToKel.Text = ((Kelvin)gradCelsius).TemperaturaKelvin.ToString();
                }
                else
                {
                    MessageBox.Show("Dato inválido, ingrese un número", "Atención", MessageBoxButtons.OK);
                }
            }
        }

        private void btnKelToAll_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtKelvin.Text))
            {
                MessageBox.Show("Ingrese un valor", "Atención", MessageBoxButtons.OK);
            }
            else
            {
                double auxKelToKel;
                if (double.TryParse(this.txtKelvin.Text, out auxKelToKel))
                {
                    Kelvin gradKelvin = new Kelvin(auxKelToKel);
                    this.txtRdoKelToKel.Text = gradKelvin.TemperaturaKelvin.ToString();
                    this.txtRdoKelToFahr.Text = ((Fahrenheit)gradKelvin).TemperaturaFahrenheit.ToString();
                    this.txtRdoKelToCel.Text = ((Celsius)gradKelvin).TemperaturaCelcius.ToString();
                }
                else
                {
                    MessageBox.Show("Dato inválido, ingrese un número", "Atención", MessageBoxButtons.OK);
                }
            }
        }
    }
}
