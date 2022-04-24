using System;
using System.Text;

namespace LogicaNegocio
{
    public abstract class Equipo
    {
        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdidos;
        protected int puntuacion;

        protected Equipo(string nombre)
        {
            this.nombre = nombre;
  
        }

        protected string Nombre 
        {
            get
            {
                return this.nombre;
            }
        }
        protected int PartidosEmpatados 
        {
            get
            {
                return this.partidosEmpatados;
            }

            set 
            { 
                this.partidosEmpatados = value;
            }     
        }
        protected int PartidosGanados
        {
            get
            {
                return this.partidosGanados;
            }

            set
            {
                this.partidosGanados = value;
            }
        }
        protected int PartidosJugados
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
        protected int PartidosPerdidos
        {
            get
            {
                return this.partidosPerdidos;
            }

            set
            {
                this.partidosPerdidos = value;
            }
        }
 
        protected int Puntuacion 
        {
            get 
            {
                return this.puntuacion;
            }
            set
            {
                this.puntuacion=value;
            }
        }

        protected string Tipo
        {
            get
            {
                return this.GetType().Name;
            }
        }
        public override bool Equals(object obj)
        { 
        }

        public abstract int GetDificultad()
        {

        }

        public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
        {
            bool sePudoJugar = false;
            if (equipoA.GetType() == equipoB.GetType())
            { 
                sePudoJugar = true;

                if (equipoA.GetDificultad() == equipoB.GetDificultad()) 
                {
                    equipoA.Puntuacion = 1;
                    equipoB.Puntuacion = 1;
                }
                {
                    if (equipoA.GetDificultad() < equipoB.GetDificultad())
                    {
                        equipoA.Puntuacion = 0;
                        equipoB.Puntuacion = 3;
                    }
                    else 
                    {
                        equipoA.Puntuacion = 3;
                        equipoB.Puntuacion = 0;
                    }

                }

                equipoA.partidosJugados++;
                equipoB.partidosJugados++;
            }
            return sePudoJugar;
        }
        protected virtual string MostrarDatos()
        {
            StringBuilder sb=new StringBuilder();

            sb.Append(this.Nombre);

            return sb.ToString();
        }

        public static bool operator == (Equipo equipoA, Equipo equipoB)
        {
            return equipoA.Tipo== equipoB.Tipo && equipoA.Nombre == equipoB.Nombre;
            
        }
        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }



    }
}
