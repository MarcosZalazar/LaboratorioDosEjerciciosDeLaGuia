using System;

namespace LogicaNegocio
{
    public class Fahrenheit
    {
        private double temperaturaFahrenheit;

        public Fahrenheit(double temperaturaFahrenheit)
        {
            this.temperaturaFahrenheit = temperaturaFahrenheit;
        }

        public double TemperaturaFahrenheit
        {
            get
            {
                return this.temperaturaFahrenheit;
            }
        }

        public static explicit operator Celsius (Fahrenheit f)
        {
            return new Celsius(Math.Round(((f.temperaturaFahrenheit - 32) * 5 / 9),2));
        }
  

        public static explicit operator Kelvin (Fahrenheit f)
        {
            return new Kelvin(Math.Round(((f.temperaturaFahrenheit + 459.67) * 5 / 9),2));
        }

    }
}
