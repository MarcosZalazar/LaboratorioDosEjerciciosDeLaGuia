using System;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int resto;
            int acumuladorDivisores;
            int contadorDeNumerosPerfectos = 0;

            //Ejercicio I04 - Un número perfecto (Unidad 1 Introducción a .NET y C#)

            for (i = 2; i > 0; i++)
            {
                acumuladorDivisores = 0;
                for (j = i - 1; j > 0; j--)
                {
                    resto = i % j;
                    if (resto == 0)
                    {
                        acumuladorDivisores = acumuladorDivisores + j;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (acumuladorDivisores == i)
                {
                    contadorDeNumerosPerfectos++;
                    Console.WriteLine("{0} es un número perfecto", i);
                }
                if (contadorDeNumerosPerfectos == 4)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            Console.ReadKey();
        }
    }
}
