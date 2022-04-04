using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadSumas;

            Sumador sumador = new Sumador();
            Sumador sumadorB = new Sumador(2);
            Sumador sumadorC = new Sumador(10);

            Console.WriteLine($"La suma de los dos long es {sumador.Sumar(45, 2)}");
            Console.WriteLine($"La suma de los dos string es {sumador.Sumar("Hola ", "Mundo")}");

            cantidadSumas = (int)sumador;
            Console.WriteLine(cantidadSumas);
            Console.WriteLine(sumador+ sumadorB);
            Console.WriteLine(sumador | sumadorB);
            Console.WriteLine(sumador | sumadorC);
        }
    }
}
