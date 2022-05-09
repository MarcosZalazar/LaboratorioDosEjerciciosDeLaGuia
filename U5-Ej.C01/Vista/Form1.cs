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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (this.btnLockCotizacion.ImageIndex == 0)
            {
                this.btnLockCotizacion.ImageIndex++;
                this.txtCotizacionEuro.Enabled = false;
                this.txtCotizacionDolar.Enabled = false;
                this.txtCotizacionPeso.Enabled = false;
            }
            else 
            {
                this.btnLockCotizacion.ImageIndex = 0;
                this.txtCotizacionEuro.Enabled = true;
                this.txtCotizacionDolar.Enabled = true;
                this.txtCotizacionPeso.Enabled = true;
            }
        }
    }
}
