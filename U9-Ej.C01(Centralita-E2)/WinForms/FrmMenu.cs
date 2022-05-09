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
    public partial class FrmMenu : Form
    {
        public Centralita unaCentralita;
        public FrmMenu()
        {
            this.unaCentralita = new Centralita();  
            InitializeComponent();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador formLlamador = new FrmLlamador(unaCentralita);
            formLlamador.ShowDialog();  
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar formFacturacionTotal=new FrmMostrar(unaCentralita);
            formFacturacionTotal.SetTipoDeLlamadas = Llamada.TipoLlamada.Todas;
            formFacturacionTotal.ShowDialog();
        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar formFacturacionLocal = new FrmMostrar(unaCentralita);
            formFacturacionLocal.SetTipoDeLlamadas = Llamada.TipoLlamada.Local;
            formFacturacionLocal.ShowDialog();
        }

        private void btnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar formFacturacionProvincial = new FrmMostrar(unaCentralita);
            formFacturacionProvincial.SetTipoDeLlamadas = Llamada.TipoLlamada.Provincial;
            formFacturacionProvincial.ShowDialog();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
