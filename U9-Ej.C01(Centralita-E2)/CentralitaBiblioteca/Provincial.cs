using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaBiblioteca
{
    public class Provincial: Llamada
    {
        protected Franja franjaHoraria;
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }
        public Provincial(string nroOrigen, Franja miFranja, float duracion, string nroDestino)
            : base(duracion, nroDestino, nroOrigen)
        {
            this.franjaHoraria = miFranja;
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
            float valorLlamada=0.00f;

            switch (this.franjaHoraria)
            { 
                case Franja.Franja_1:
                    valorLlamada = 0.99f;
                    break;
                case Franja.Franja_2:
                    valorLlamada = 1.25f;
                    break;
                case Franja.Franja_3:
                    valorLlamada = 0.66f;
                    break;
            }
            valorLlamada = base.Duracion * valorLlamada;
            
            return valorLlamada;
        }
        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            
            sb.Append($"Llamada:{Environment.NewLine}");
            sb.AppendLine("----------------------------------------------------------");
            sb.AppendLine($"{base.Mostrar()}");
            sb.AppendLine($"Costo de la llamada: {this.CostoLlamada} Franja Horaria: {this.franjaHoraria}");
            sb.AppendLine("----------------------------------------------------------");

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
