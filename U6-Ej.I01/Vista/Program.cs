using System;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I01 - Números locos (Unidad 6 Colecciones)

            Random numeroRandom = new Random();
            int[] arrayNumerosAleatorios = new int[20];

            for (int i = 0; i < arrayNumerosAleatorios.Length; i++)
            {
                arrayNumerosAleatorios[i] = numeroRandom.Next(-500, 500);
            }

            Console.WriteLine("Array original sin ordenar");

            foreach (int numero in arrayNumerosAleatorios)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("-----------");

            Console.WriteLine("Elementos positivos del array(orden decreciente)");
            Array.Sort(arrayNumerosAleatorios, OrdenarDecreciente);

            for (int j = 0; j < arrayNumerosAleatorios.Length; j++)
            {
                if (arrayNumerosAleatorios[j] >=0)
                {
                    Console.WriteLine("{0}", arrayNumerosAleatorios[j]);
                }

            }

            Console.WriteLine("-----------");

            Console.WriteLine("Elementos negativos del array(orden creciente)");
            Array.Sort(arrayNumerosAleatorios);

            for (int k = 0; k < arrayNumerosAleatorios.Length; k++)
            {
                if (arrayNumerosAleatorios[k] < 0)
                {
                    Console.WriteLine("{0}", arrayNumerosAleatorios[k]);
                }

            }

            static int OrdenarDecreciente(int a, int b)
            {
                return b - a;
            }
        }
    }
}
