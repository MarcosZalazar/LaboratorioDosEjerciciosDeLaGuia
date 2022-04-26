using System;
using System.Text;

namespace Entidades
{
    public abstract class Equipo
    {

        protected string nombre;
        protected int puntuacion;
        protected int partidosJugados;
        protected int partidosGanados;
        protected int partidosEmpatados;
        protected int partidosPerdidos;

        /// <summary>
        /// Constructor de equipo
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="categoria"></param>
        protected Equipo(string nombre)
        {
            this.nombre = nombre;

        }

        public string Nombre { get => this.nombre; }

        /// <summary>
        /// Metodo abstracto que retorna la dificultad de cada equipo en base a sus condiciones.
        /// No es una propiedad para que el agregar al datagrid, no muestre datos que no quiero :D, como la dificultad
        /// </summary>
        /// <returns></returns>
        public abstract int GetDificultad();
        public string Tipo { get => this.GetType().Name; } 
        public int Puntuacion { get => this.puntuacion; set => this.puntuacion = value > 0 ? value : 0; }
        public  int PJ { get => this.partidosJugados; set => this.partidosJugados = value > 0 ? value : 0; }
        public int PG { get => partidosGanados; set => this.partidosGanados = value > 0 ? value : 0; }
        public int PE { get => partidosEmpatados; set => this.partidosEmpatados = value > 0 ? value : 0; }
        public int PP { get => partidosPerdidos; set => this.partidosPerdidos = value > 0 ? value : 0; }

        /// <summary>
        /// Dos equipos son iguales si su nombre es igual al del otro y son de la misma division.
        /// La idea es usar esta sobrecarga al momento de agregar equipos al torneo
        /// </summary>
        /// <param name="equipoA"></param>
        /// <param name="equipoB"></param>
        /// <returns></returns>
        public static bool operator ==(Equipo equipoA, Equipo equipoB)
        {
            return equipoA.nombre == equipoB.nombre && equipoA.Equals(equipoB);
        }
        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }

        /// <summary>
        /// Compara dos equipos por el tipo y la categoria a la que pertenece, la idea es reutilizar esta sobrecarga para jugar el partido
        /// si son de desitinta division o tipo, no se jugara.
        /// </summary>
        /// <param name="obj">Es el equipo a comparar con la instancia</param>
        /// <returns>True en caso exitoso, False de lo contrario</returns>
        public override bool Equals(object obj)
        {
            
            return this.GetType() == obj.GetType();
        }

        /// <summary>
        /// Muestra los datos del equipo, solo el nombre para exponerlo en el ComboBox del Form
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Nombre);
            return sb.ToString();

        }


        /// <summary>
        /// Metodo que simula una competencia en base a la dificultad de cada equipo
        /// </summary>
        /// <param name="equipoA"></param>
        /// <param name="equipoB"></param>
        /// <returns></returns>
        public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
        {
            bool returnAux = false;
            if (equipoA.Equals(equipoB))
            {
                returnAux = true;
                equipoA.PJ++;
                equipoB.PJ++;
                if (equipoA.GetDificultad() > equipoB.GetDificultad())
                {
                    equipoA.PG++;
                    equipoB.PP++;
                    equipoA.Puntuacion += 3;
                }
                else if (equipoA.GetDificultad() < equipoB.GetDificultad())
                {
                    equipoA.PP++;
                    equipoB.PG++;
                    equipoB.Puntuacion += 3;
                }
                else
                {
                    equipoA.Puntuacion += 1;
                    equipoB.Puntuacion += 1;
                    equipoA.PE++;
                    equipoB.PE++;
                }
            }
            return returnAux;
        }

    }
}
