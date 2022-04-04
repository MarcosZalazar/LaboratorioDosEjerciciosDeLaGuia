using System;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I08 - Dibujando un triángulo rectángulo (Unidad 1 Introducción a .NET y C#)

            int i;
            int j;
            int alturaPiramide;

            Console.WriteLine("Ingrese la altura de la piramide: ");
            alturaPiramide = int.Parse(Console.ReadLine());

            for (i = 1; i <= (alturaPiramide * 2); i = i + 2)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
