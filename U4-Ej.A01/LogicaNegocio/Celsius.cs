using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Celsius
    {
        private double temperaturaCelcius;

        public Celsius(double temperaturaCelcius)
        {
            this.temperaturaCelcius = temperaturaCelcius;
        }

        public double TemperaturaCelcius
        {
            get
            {
                return this.temperaturaCelcius;
            }
        }

        public static explicit operator Fahrenheit (Celsius c)
        {
            return new Fahrenheit(Math.Round((c.TemperaturaCelcius* 9 / 5+ 32),2));
        }

        public static explicit operator Kelvin(Celsius c)
        {
            return (Kelvin)((Fahrenheit)c);
        }
        
    }
}
