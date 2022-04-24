using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class EquipoFutbol:Equipo
    {
        protected bool jugadoresEstrellas;

        public EquipoFutbol(string nombre) : base(nombre)
        {
        }
        public EquipoFutbol(string nombre, bool jugadoresEstrellas) : base(nombre)
        {
            this.jugadoresEstrellas = false;
        }
        public int GetDificultad()
        {
            Random rand = new Random();
            int dificultadRandom= rand.Next(7, 10);

            if (this.jugadoresEstrellas==true)
            {
                dificultadRandom = dificultadRandom * 2;
            }
            return dificultadRandom;
        }
        public string MostrarDatos()
        {
            return $"Futbol"+this.Nombre;

        }   

        public string ToString()
        {
            MostrarDatos();

            return;
        }
    }
}
