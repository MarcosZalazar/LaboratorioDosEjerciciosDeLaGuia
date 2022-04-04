using System;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int i;
            int j;
            int resto;
            int contadorDivisores;

            //Ejercicio I03 - Los primos (Unidad 1 Introducción a .NET y C#)

            Console.WriteLine("Ingrese un número: ");
            numeroIngresado = int.Parse(Console.ReadLine());

            while (numeroIngresado < 0)
            {
                Console.WriteLine("Error! Ingrese un número entero positivo");
            }
            for (i = numeroIngresado; i > 1; i--)
            {
                contadorDivisores = 1;
                for (j = i - 1; j > 0; j--)
                {
                    resto = i % j;
                    if (resto == 0)
                    {
                        contadorDivisores++;
                    }
                    if (contadorDivisores > 2)
                    {
                        break;
                    }
                }
                if (contadorDivisores == 2)
                {
                    Console.WriteLine("{0} es un número primo", i);
                }
            }
            Console.ReadKey();
        }
    }
}
