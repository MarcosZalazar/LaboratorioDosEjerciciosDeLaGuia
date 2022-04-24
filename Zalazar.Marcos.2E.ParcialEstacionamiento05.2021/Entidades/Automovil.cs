using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Automovil : Vehiculo
    {
        private string marca;
        private static double valorHora;

        static Automovil()
        {
            valorHora = 120;
        }
        public Automovil(string patente, DateTime horaIngreso, string marca):base(patente, horaIngreso)
        {
            this.marca = marca; 
        }

        public override double CostoEstadia
        {
            get
            {
                return valorHora * ((this.HoraEgreso-this.HoraIngreso).TotalHours);
            }
        }

        public override string Descripcion
        {
            get
            {
                return this.marca;

            }
        }
        public static double ValorHora
        {
            set
            {
                if (value>0)
                {
                    valorHora = value;
                }
            }
        }

        protected override double CargoDeEstacionamiento()
        {
            return this.CostoEstadia;

        }

        protected override string MostrarDatos()
        {
            return $"****AUTOMOVIL*****"+this.Descripcion;

        }

        public new string ToString()
        {
            return MostrarDatos();
        }
    }
}
