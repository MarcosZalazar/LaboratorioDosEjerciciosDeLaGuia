using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
          
            Console.WriteLine("Ingrese un número: ");
            int.TryParse(Console.ReadLine(), out numeroIngresado);

            Console.WriteLine("\nTabla de multiplicar del número {0}",numeroIngresado);
            Console.WriteLine(Tablas.DevolverTabla(numeroIngresado));

            Console.ReadKey();
        }
    }
}

