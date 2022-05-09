using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(long dni, string nombre):base(dni,nombre)
        {

        }
        public Jugador(long dni, string nombre, int totalGoles, int totalPartidos):this(dni,nombre) 
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }
        public float PromedioDeGoles
        {
            get
            {
                return (float)this.totalGoles / this.partidosJugados;
            }
        }
        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
            set
            {
                this.totalGoles = value;
            }
        }
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine("Total de goles: " + this.totalGoles.ToString());
            sb.AppendLine("Partidos jugados: " + this.partidosJugados.ToString());
            sb.AppendLine("Promedio de goles: " + this.PromedioDeGoles.ToString());

            return sb.ToString();
        }
        public static bool operator == (Jugador j1, Jugador j2)
        {
            if (j1 is not null && j2 is not null)
            {
                if (((Persona)j1).Dni == ((Persona)j2).Dni)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator != (Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
