using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoBasket : Equipo
    {
        public enum ELiga {NBA,Euroleague,ACB};
        private ELiga liga;

        /// <summary>
        /// Constructor de basket sin Liga, por defecto sera NBA
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="categoria"></param>
        public EquipoBasket(string nombre) 
            : this(nombre, ELiga.NBA)
        {
        }

        /// <summary>
        /// contructor basket que adiciona la liga, este parametro detemrinara la dificultad del equipo.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="categoria"></param>
        /// <param name="liga"></param>
        public EquipoBasket(string nombre, ELiga liga)
            : base(nombre)
        {
            this.liga = liga;
        }

        /// <summary>
        /// metodo que retorna la dificultad del equipo, la misma es randon en base a la liga a la cual pertenece el equipo.
        /// </summary>
        /// <returns></returns>
        public override int GetDificultad()
        {
            Random dificultadRandom = new Random();
            switch (this.liga)
            {
                case ELiga.NBA:
                    {
                        return dificultadRandom.Next(8, 10);
                    }
                case ELiga.Euroleague:
                    {
                        return dificultadRandom.Next(5, 10);
                    }
                default:
                    {
                        return dificultadRandom.Next(1, 7);
                    }
                 
            }
        }
        /// <summary>
        /// Agrega basket al nombre del equipo 
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Basket - ");
            sb.Append(base.MostrarDatos());
            return sb.ToString();
        }

        /// <summary>
        /// Espone los datos del objeto
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
