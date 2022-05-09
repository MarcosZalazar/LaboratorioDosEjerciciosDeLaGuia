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
    public partial class FormConversor : Form
    {
        public FormConversor()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            this.txtResultadoDec.Text = ((NumeroDecimal)((NumeroBinario)this.txtBinario.Text)).Numero.ToString(); 
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            double ingresoAux;

            if (double.TryParse(this.txtDecimal.Text, out ingresoAux))
            {
                this.txtResultadoBin.Text = ((NumeroBinario)((NumeroDecimal)ingresoAux)).Numero.ToString();
            }
            else 
            {
                this.txtResultadoBin.Text = "Datos erroneos";
            }
        }
    }
}
