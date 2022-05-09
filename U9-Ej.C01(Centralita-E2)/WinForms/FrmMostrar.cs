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
    public partial class FrmMostrar : Form
    {
        private Llamada.TipoLlamada tipoDeLaLlamada;
        private Centralita centralitaAInformar;

        public FrmMostrar(Centralita centralitaDelMenu)
        {
            InitializeComponent();
            this.centralitaAInformar=centralitaDelMenu;
        }

        public Llamada.TipoLlamada SetTipoDeLlamadas
        {
            set
            {
                this.tipoDeLaLlamada = value;        
            }
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            if (this.tipoDeLaLlamada is Llamada.TipoLlamada.Local)
            {
                this.rtxMostrar.Text = $"Llamada Local{Environment.NewLine}{Environment.NewLine}Ganancia: $ {Math.Round((centralitaAInformar.GananciasPorLocal),2).ToString()}";

            }
            else
            {
                if (this.tipoDeLaLlamada is Llamada.TipoLlamada.Provincial)
                {
                    this.rtxMostrar.Text = $"Llamada Provincial{Environment.NewLine}{Environment.NewLine}Ganancia: $ {Math.Round((centralitaAInformar.GananciasPorProvincial),2).ToString()}";
                }
                else
                {
                    this.rtxMostrar.Text = $"Llamadas locales y provinciales{Environment.NewLine}{Environment.NewLine}Ganancia: $ {Math.Round((centralitaAInformar.GananciasPorTotal),2).ToString()}";
                }
            }
        }

        private void FrmMostrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
