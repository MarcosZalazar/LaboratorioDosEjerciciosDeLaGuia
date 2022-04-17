using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class VehiculoTerrestre
    {

        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;

        public enum Colores
        {
            Rojo, Blanco, Azul, Gris, Negro
        }

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

    }
}
