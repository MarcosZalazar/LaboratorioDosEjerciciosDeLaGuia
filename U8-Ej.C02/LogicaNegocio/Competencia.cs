using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Competencia
    {
        public enum TipoCompetencia
        { 
            F1,
            MotoCross
        }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo):this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }
        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }
        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }
        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public static bool operator == (Competencia c, VehiculoDeCarrera v)
        {
            if ((c.Tipo == Competencia.TipoCompetencia.F1 && v.GetType() == typeof(AutoF1)) || (c.Tipo == Competencia.TipoCompetencia.MotoCross && v.GetType() == typeof(MotoCross)))
            {
                if (c is not null && v is not null && c.competidores.Count > 0)
                {
                    foreach (VehiculoDeCarrera competidor in c.competidores)
                    {
                        if (competidor == v)
                        {
                            return true;
                        }
                    }
                }
            }
            else 
            {
                return true;
            }
            return false;
        }

        public static bool operator != (Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

        public static bool operator + (Competencia c, VehiculoDeCarrera v)
        {
            Random combustibleRandom = new Random();

            if (c is not null && v is not null)
            {
                if (c.competidores.Count < c.CantidadCompetidores && c != v)
                {
                    c.competidores.Add(v);
                    v.EnCompetencia=true;
                    v.VueltasRestantes=c.CantidadVueltas;
                    v.CantidadCombustible=(short)combustibleRandom.Next(15, 101);
                    return true;
                }
            }
            return false;
        }
        public static bool operator - (Competencia c, VehiculoDeCarrera v)
        {
            if (c is not null && v is not null)
            {
                if (c == v)
                {
                    c.competidores.Remove(v);
                    return true;
                }
            }
            return false;

        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Tipo de competencia: " + this.Tipo);
            sb.AppendLine("Cantidad de competidores: " + this.CantidadCompetidores);
            sb.AppendLine("Cantidad de vueltas: " + this.CantidadVueltas);
            foreach (VehiculoDeCarrera competidor in this.competidores)
            {
                if (competidor is not null && competidor is AutoF1)
                {
                    sb.AppendLine("----------------------");
                    sb.AppendLine("Datos del vehículo: ");
                    sb.AppendLine(Environment.NewLine);
                    sb.AppendLine(((AutoF1) competidor).MostrarDatos());
                    sb.AppendLine("----------------------");
                }
                else
                {
                    if (competidor is not null && competidor is MotoCross)
                    {
                        sb.AppendLine("----------------------");
                        sb.AppendLine("Datos del vehículo: ");
                        sb.AppendLine(Environment.NewLine);
                        sb.AppendLine(((MotoCross)competidor).MostrarDatos());
                        sb.AppendLine("----------------------");
                    }
                }
            }
            return sb.ToString();
        }
    }

}
