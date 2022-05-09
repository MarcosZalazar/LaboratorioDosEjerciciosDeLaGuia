using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Kelvin
    {
        private double temperaturaKelvin;

        public Kelvin(double temperaturaKelvin)
        {
            this.temperaturaKelvin = temperaturaKelvin;
        }

        public double TemperaturaKelvin 
        {
            get
            {
                return this.temperaturaKelvin;
            }
        }

        public static explicit operator Fahrenheit (Kelvin k)
        {
            return new Fahrenheit(k.TemperaturaKelvin* 9 / 5 - 459.67);
        }

        
        public static explicit operator Celsius(Kelvin k)
        {
            return (Celsius)((Fahrenheit)k);
        }
    }
}
