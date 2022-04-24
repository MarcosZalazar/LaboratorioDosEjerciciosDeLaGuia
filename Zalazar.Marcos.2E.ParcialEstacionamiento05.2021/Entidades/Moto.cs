using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Moto:Vehiculo
    {
        public enum ETipo
        {
            Ciclomotor,
            Scooter,
            Sport
        }

        private ETipo tipo;
        private static double valorHora;

        static Moto()
        {
            valorHora = 100;
        }

        public Moto(string patente,DateTime horaIngreso, ETipo tipo):base(patente, horaIngreso)
        {
            this.tipo = tipo;
        }

        public override double CostoEstadia
        {
            get
            {
                return CargoDeEstacionamiento();
            }
        }

        public override string Descripcion
        {
            get
            {
                return tipo.ToString();
            }
        }
        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    valorHora = value;  
                }
            }
        }

        protected override double CargoDeEstacionamiento()
        {
            return valorHora * ((this.HoraEgreso - this.HoraIngreso).TotalHours);

        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.MostrarDatos()}");
            sb.AppendLine("****MOTO*****");
            sb.AppendLine($"{this.Descripcion}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return MostrarDatos();
        }
    }
}
