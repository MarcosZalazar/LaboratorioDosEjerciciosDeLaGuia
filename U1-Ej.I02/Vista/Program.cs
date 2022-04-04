using System;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I02 - Error al cubo (Unidad 1 Introducción a .NET y C#)

            int numeroIngresado;
            double numeroAlCuadrado;
            double numeroAlCubo;

            Console.WriteLine("Ingrese un número: ");

            numeroIngresado = int.Parse(Console.ReadLine());
            while (numeroIngresado <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }

            numeroAlCuadrado = Math.Pow(numeroIngresado, 2);
            numeroAlCubo = Math.Pow(numeroIngresado, 3);

            Console.WriteLine("El numero ingresado es {0}, el cuadrado es {1}, y el cubo es {2}", numeroIngresado, numeroAlCuadrado, numeroAlCubo);
            Console.ReadKey();
        }
    }
}
