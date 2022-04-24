using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local:Llamada
    {
        protected float costo;

        public Local(Llamada llamada,float costo) : this(llamada.NroOrigen,llamada.Duracion, llamada.NroDestino,costo)
        {
            
        }

        public Local(string nroOrigen, float duracion, string nroDestino, float costo) 
            : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }

        public float Costo 
        {
            get 
            { 
                return this.costo; 
            }
        }
        private float CalcularCosto()
        { 

        }
        public string Mostrar()
        {

        }

    }
}
