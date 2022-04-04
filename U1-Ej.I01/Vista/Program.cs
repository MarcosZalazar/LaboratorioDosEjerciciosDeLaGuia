using System;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroMaximo = int.MinValue;
            int numeroMinimo = int.MaxValue;
            int acumuladorNumero = 0;
            float promedioNumeros;
            int i;

            //Ejercicio I01 - Máximo, mínimo y promedio (Unidad 1 Introducción a .NET y C#)

            for (i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un número: ");
                int.TryParse(Console.ReadLine(), out numeroIngresado);

                if (i == 0)
                {
                    numeroMaximo = numeroIngresado;
                    numeroMinimo = numeroIngresado;
                }
                else
                {
                    if (numeroIngresado > numeroMaximo)
                    {
                        numeroMaximo = numeroIngresado;
                    }
                    if (numeroIngresado < numeroMinimo)
                    {
                        numeroMinimo = numeroIngresado;
                    }
                }
                acumuladorNumero = acumuladorNumero + numeroIngresado;
            }
            promedioNumeros = acumuladorNumero / i;

            Console.WriteLine("El número máximo ingresado es {0,0:#.###,00}, el mínimo es {1,0:#.###,00} y el promedio es {2,0:#.###,00}", numeroMaximo, numeroMinimo, promedioNumeros);

            Console.ReadKey();
        }
    }
}
