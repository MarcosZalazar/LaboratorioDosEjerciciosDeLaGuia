using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public enum ELiga 
    { 
        NBA,
        Euroleague,
        ACB
    }
    public class EquipoBasket:Equipo
    {
        private ELiga liga;

        public EquipoBasket(string nombre) : base(nombre)
        {
        }
        public EquipoBasket(string nombre, ELiga liga) : base(nombre)
        {
            liga = NBA;
        }
        public int GetDificultad()
        {
            Random rand = new Random();
            int numeroRandom;

            switch(liga)
            {
                case NBA:
                    numeroRandom = rand.Next(8, 10);
                break;
                case EuroLeague:
                    numeroRandom = rand.Next(5, 10);
                    break;
                case ACB:
                    numeroRandom = rand.Next(1, 7);
                    break;
            }
   

        }
        public string MostrarDatos()
        {
            return $"Basket" + this.Nombre;
        }

        public string ToString()
        {
            MostrarDatos();

            return;

        }
    }

}
