using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaBiblioteca
{
    public abstract class Llamada
    {
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public abstract float CostoLlamada
        {
            get;
        }

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nro. Origen: {this.NroOrigen} Nro. Destino: { this.NroDestino} Duración: { this.Duracion} ");

            return sb.ToString();
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if ((l1 is not null) && (l2 is not null))
            {
                return l1.Equals(l2);
            }
            return false;
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1==l2);
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return llamada1.Duracion.CompareTo(llamada2.Duracion);
        }
    }
}
