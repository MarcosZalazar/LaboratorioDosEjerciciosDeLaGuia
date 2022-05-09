using System;
using System.Text;

namespace LogicaNegocio
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }
        
        public short CantidadCombustible
        {
            get 
            {
                return this.cantidadCombustible;
            }
            set 
            { 
                this.cantidadCombustible = value;   
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }
        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }
        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }

        public static bool operator == (VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            if (v1 is not null && v2 is not null)
            {
                if ((v1.Numero == v2.Numero) && (v1.Escuderia == v2.Escuderia))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(VehiculoDeCarrera v1, VehiculoDeCarrera v2)
        {
            return !(v1 == v2);
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Numero de vehículo: " + this.Numero);
            sb.AppendLine("Escuderia: " + this.Escuderia);
            sb.AppendLine("En competencia?: " + this.EnCompetencia);
            sb.AppendLine("Cantidad de combustible: " + this.CantidadCombustible);
            sb.AppendLine("Vueltas Restantes: " + this.VueltasRestantes);

            return sb.ToString();
        }
    }
}
