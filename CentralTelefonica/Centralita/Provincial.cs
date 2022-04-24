using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Provincial:Llamada
    {
        protected Franja franjaHoraria;
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        public Provincial(Franja miFranja, Llamada llamada):this(llamada.NroOrigen,miFranja, llamada.Duracion, llamada.NroDestino)
        {
            
        }
        public Provincial(string nroOrigen, Franja miFranja, float duracion, string nroDestino) 
            : base(duracion, nroDestino, nroOrigen)
        {   
            this.franjaHoraria=miFranja;
        }

        private float CalcularCosto()
        {

        }
        public string Mostrar()
        {

        }


    }
}
