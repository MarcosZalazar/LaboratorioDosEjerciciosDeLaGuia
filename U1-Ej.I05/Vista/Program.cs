using System;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int k;
            int numeroIngresado;
            int acumuladorNumerosAIzquierda;
            int acumuladorNumerosADerecha;

            //Ejercicio I05 - Tirame un centro (Unidad 1 Introducción a .NET y C#)

            Console.WriteLine("Ingrese un número: ");
            numeroIngresado = int.Parse(Console.ReadLine());

            for (i = 1; i < numeroIngresado; i++)
            {
                acumuladorNumerosAIzquierda = 0;
                acumuladorNumerosADerecha = 0;
                for (j = i - 1; j > 0; j--)
                {
                    acumuladorNumerosAIzquierda = acumuladorNumerosAIzquierda + j;
                }
                k = i + 1;
                while (acumuladorNumerosADerecha < acumuladorNumerosAIzquierda)
                {
                    acumuladorNumerosADerecha = acumuladorNumerosADerecha + k;
                    if (acumuladorNumerosAIzquierda == acumuladorNumerosADerecha)
                    {
                        Console.WriteLine("El número {0} es un centro numérico", i);
                    }
                    k++;
                }
            }
            Console.ReadKey();
        }
    }
}
