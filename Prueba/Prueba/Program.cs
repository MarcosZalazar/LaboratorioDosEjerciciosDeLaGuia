using System;
using LogicaNegocio;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(i.FizzBuzz());
            }

            Console.ReadKey();
        }
    }
}
