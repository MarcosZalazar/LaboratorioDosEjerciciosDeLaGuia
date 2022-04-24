using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace View
{
    public partial class FrmTest : Form
    {
        private Vendedor vendedor;
        public FrmTest()
        {
            InitializeComponent();
            this.vendedor = new Vendedor("Pablo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            lstStock.Items.Add(p1);
            lstStock.Items.Add(p2);
            lstStock.Items.Add(p3);
            lstStock.Items.Add(p4);
            lstStock.Items.Add(p5);
        }

        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason==CloseReason.UserClosing)
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Publicacion publicacion = lstStock.SelectedItem as Publicacion;

            if (publicacion is not null)
            {
                if (vendedor + publicacion)
                {
                    MessageBox.Show("Venta Realizada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Venta no realizada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            rtbInforme.Text = Vendedor.ObtenerInformeDeVentas(vendedor);
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
