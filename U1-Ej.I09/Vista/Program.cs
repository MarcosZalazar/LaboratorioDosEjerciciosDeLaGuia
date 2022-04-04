using System;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I09 - Dibujando un triángulo equilátero (Unidad 1 Introducción a .NET y C#)

            int i;
            int j;
            int k;
            int alturaPiramide;

            Console.WriteLine("Ingrese la altura de la piramide: ");
            alturaPiramide = int.Parse(Console.ReadLine());

            for (i = 1; i <= alturaPiramide; i++)
            {

                for (j = 1; j <= alturaPiramide - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= (i * 2) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
