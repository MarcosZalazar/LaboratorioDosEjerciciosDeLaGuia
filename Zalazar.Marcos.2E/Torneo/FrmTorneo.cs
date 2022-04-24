using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torneo
{
    public partial class FrmTorneo : Form
    {
        public FrmTorneo()
        {
            InitializeComponent();
        }

        private void FrmTorneo_Load(object sender, EventArgs e)
        {
            this.competencia = new Competencia("Torneos el Foquito", 10);
            Equipo e1 = new EquipoFutbol("Independiente", true);
            Equipo e2 = new EquipoFutbol("Boca", true);
            Equipo e3 = new EquipoBasket("Spurs");
            Equipo e4 = new EquipoBasket("Chicago Bulls");
            Equipo e5 = new EquipoFutbol("Racing");
            this.competencia += e1;
            this.competencia += e1;//pruebo de agregar el mismo equipo
            this.competencia += e2;
            this.competencia += e3;
            this.competencia += e4;
            this.competencia += e5;
            this.cmbEquipoUno.DataSource = this.competencia.Equipos;
            this.rchtDatosTorneo.Text +=
           Competencia.MostrarTorneo(this.competencia);

        }
    }
}
