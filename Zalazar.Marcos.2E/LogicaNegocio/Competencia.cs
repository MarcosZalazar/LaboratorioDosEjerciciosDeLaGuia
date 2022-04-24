using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Competencia
    {
        private int cantidaCompetidores;
        private List<Equipo> equipos;
        private string nombre;

        public Competencia(string nombre)
        {
            this.nombre = nombre;
        }
        private Competencia(string nombre,int cantidaCompetidores):this(nombre)
        {
            this.cantidaCompetidores = 5;
        }

    
        protected int CantidadCompetidores
        {
            get
            {
                return this.cantidaCompetidores;
            }

            set
            {
                this.cantidaCompetidores = value;
            }
        }
        protected List<Equipo> Equipos
        {
            get
            {
                return this.Equipos;
            }
        }
        protected string Nombre
        {
            get
            {
                return this.Nombre;
            }

            set
            {
                this.Nombre = value;
            }
        }
        public string MostrarTorneo(Competencia torneo)
        {

        }

        public static implicit operator Competencia(string nombre, int cantidadCompetidores)
        {

        }
        public static bool operator ==(Competencia torneo, Equipo equipo)
        {

        }
        public static bool operator !=(Competencia torneo, Equipo equipo)
        {

        }
        public static Competencia operator +(Competencia torneo, Equipo equipo)
        {

        }
    }
}
