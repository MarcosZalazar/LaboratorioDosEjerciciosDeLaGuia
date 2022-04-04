using System;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I06 - Años bisiestos (Unidad 1 Introducción a .NET y C#)

            int anioDeInicio;
            int anioDeFin;
            int i;
            int restoMultiploDeCuatro;
            int restoMultiploDeCien;
            int restoMultiploDeCuatrocientos;

            Console.WriteLine("Ingrese un año de inicio");
            anioDeInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un año de cierre");
            anioDeFin = int.Parse(Console.ReadLine());

            for (i = anioDeInicio; i <= anioDeFin; i++)
            {
                restoMultiploDeCuatro = i % 4;
                if (restoMultiploDeCuatro == 0)
                {
                    restoMultiploDeCien = i % 100;
                    restoMultiploDeCuatrocientos = i % 400;
                    if ((restoMultiploDeCien != 0 && restoMultiploDeCuatrocientos != 0) || (restoMultiploDeCien == 0 && restoMultiploDeCuatrocientos == 0))
                    {
                        Console.WriteLine("{0} es un año bisiesto", i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
