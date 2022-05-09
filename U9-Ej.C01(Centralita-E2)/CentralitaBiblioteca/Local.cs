using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaBiblioteca
{
    public class Local: Llamada
    {

        protected float costo;

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        public Local(string nroOrigen, float duracion, string nroDestino, float costo)
            : base(duracion, nroDestino, nroOrigen)
        {
            this.costo = costo;
        }

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        private float CalcularCosto()
        {
            float valorLlamada;

            valorLlamada =base.Duracion*this.costo;

            return valorLlamada;
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Llamada:{Environment.NewLine}");
            sb.AppendLine("----------------------------------------------------------");
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Costo de la llamada: {this.CostoLlamada}");
            sb.AppendLine("----------------------------------------------------------");

            return sb.ToString();
        }

        public override string ToString()
        { 
            return Mostrar();
        }
    }
}
