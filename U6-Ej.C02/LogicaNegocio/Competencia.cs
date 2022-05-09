using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia()
        {
            this.competidores = new List<AutoF1>(); 
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores):this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Cantidad de competidores: " + this.cantidadCompetidores);
            sb.AppendLine("Cantidad de vueltas: " + this.cantidadVueltas);
            foreach (AutoF1 competidor in this.competidores)
            {
                if (competidor is not null)
                {
                    sb.AppendLine("----------------------");
                    sb.AppendLine("Datos del auto: ");
                    sb.AppendLine(Environment.NewLine);
                    sb.AppendLine(competidor.MostrarDatos());
                    sb.AppendLine("----------------------");
                }
            }
            return sb.ToString();
        }
        public static bool operator == (Competencia c, AutoF1 a)
        {
            if (c is not null && a is not null && c.competidores.Count>0)
            {
                foreach (AutoF1 competidor in c.competidores)
                {
                    if (competidor == a)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator != (Competencia c, AutoF1 a)
        {
            return !(c == a);
        }

        public static bool operator + (Competencia c, AutoF1 a)
        {
            Random combustibleRandom = new Random();

            if (c is not null && a is not null)
            {
                if (c.competidores.Count<c.cantidadCompetidores && c!=a)
                { 
                    c.competidores.Add(a);
                    a.SetEnCompetencia(true);
                    a.SetVueltasRestantes(c.cantidadVueltas);
                    a.SetCantidadCombustible((short)combustibleRandom.Next(15, 101));
                    c.cantidadCompetidores++;
                    return true;
                }
            }
            return false;
        }
        public static bool operator - (Competencia c, AutoF1 a)
        {
            if (c is not null && a is not null)
            {
                if (c==a)
                {
                    c.competidores.Remove(a);
                    return true;
                }
            }
            return false;
        }
    }
}
