using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I07 - Pitágoras estaría orgulloso (Unidad 2 Clases y métodos estáticos)

            double primerCateto;
            double segundoCateto;
            double hipotenusaCalculada;

            Console.WriteLine("\nIngrese la longitud del primer cateto");
            double.TryParse(Console.ReadLine(), out primerCateto);
            Console.WriteLine("\nIngrese la longitud del segundo cateto");
            double.TryParse(Console.ReadLine(), out segundoCateto);

            hipotenusaCalculada = Triangulo.CalcularHipotenusa(primerCateto, segundoCateto);
            Console.WriteLine($"\nLa hipotenusa del triángulo es {hipotenusaCalculada}");

            Console.ReadKey();
        }
    }
}
