using System;
using System.Text;

namespace LogicaNegocio
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;   
            this.escuderia = escuderia;
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }
        public void SetEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia= enCompetencia;
        }

        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }
        public void SetCantidadCombustible(short cantidadCombustible)
        {
            this.cantidadCombustible = cantidadCombustible;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }
        public void SetVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
        }

        public string MostrarDatos()
        {
            StringBuilder sb= new StringBuilder();

            sb.AppendLine("Numero de auto: "+this.numero);
            sb.AppendLine("Escuderia: " + this.escuderia);
            sb.AppendLine("En competencia?: " + this.GetEnCompetencia());
            sb.AppendLine("Cantidad de combustible: " + this.GetCantidadCombustible());
            sb.AppendLine("Vueltas Restantes: " + this.GetVueltasRestantes());

            return sb.ToString();
        }

        public static bool operator == (AutoF1 a1, AutoF1 a2)
        {
            if (a1 is not null && a2 is not null)
            {
                if ((a1.numero == a2.numero) && (a1.escuderia == a2.escuderia))
                { 
                    return true;
                }
            }
            return false;
        }

        public static bool operator != (AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2); 
        }
    }
}
