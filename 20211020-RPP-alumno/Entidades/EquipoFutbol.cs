using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoFutbol : Equipo
    {
        private bool jugadoresEstrellas;
        /// <summary>
        /// Constructor de Equipo de futbol, que determina si este tiene jugadores estrellas
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="categoria"></param>
        /// <param name="jugadoresEstrellas"></param>
        public EquipoFutbol(string nombre, bool jugadoresEstrellas) 
            : base(nombre)
        {
            this.jugadoresEstrellas = jugadoresEstrellas;

        }
        /// <summary>
        /// constuctor de equipo de futbol, por defecto un equipo de futbol no tiene jugadores estrellas.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="categoria"></param>
        public EquipoFutbol(string nombre) 
            : this(nombre, false)
        {
        }

        /// <summary>
        /// Metodo que retona la dificultad random de un equipo, si este tiene jugadores estrellas su dificultad se doblegara.
        /// </summary>
        /// <returns></returns>
        public override int GetDificultad()
        {
   
            Random dificultadRandom = new Random();
            if (this.jugadoresEstrellas)
            {
                return (dificultadRandom.Next(7, 10) * 2);
            }

            return dificultadRandom.Next(7, 10);
        }

        /// <summary>
        /// Mostrar datos agrega la descripcion que es un equipo de futbol al nombre.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Futbol - ");
            sb.Append(base.MostrarDatos());
            return sb.ToString();
        }

        /// <summary>
        /// Metodo hace publicos los datos de un equipo.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }


    }
}
