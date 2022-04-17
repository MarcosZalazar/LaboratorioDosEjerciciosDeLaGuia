using System;
using LogicaNegocio;


namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio A01 - Fahrenheit 451(Unidad 4 Sobrecarga)

            Fahrenheit tempF1 = new Fahrenheit(100);
            Console.WriteLine($"Temperatura en Fahrenheit:{tempF1.TemperaturaFahrenheit}, equivale a Celsius:{((Celsius)tempF1).TemperaturaCelcius} y Kelvin:{((Kelvin)tempF1).TemperaturaKelvin}");
            Console.WriteLine("--------------------------");

            Celsius tempC1 = new Celsius(100);
            Console.WriteLine($"Temperatura en Celsius:{tempC1.TemperaturaCelcius}, equivale a Fahrenheit:{((Fahrenheit)tempC1).TemperaturaFahrenheit} y Kelvin:{((Kelvin)tempC1).TemperaturaKelvin}");
            Console.WriteLine("--------------------------");

            Kelvin tempK1 = new Kelvin(100);
            Console.WriteLine($"Temperatura en Kelvin:{tempK1.TemperaturaKelvin}, equivale a Celsius:{((Celsius)tempK1).TemperaturaCelcius} y Fahrenheit:{((Fahrenheit)tempK1).TemperaturaFahrenheit}");
        }
    }
}
