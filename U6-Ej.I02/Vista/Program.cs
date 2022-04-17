using System;
using System.Collections.Generic;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I02 - Números locos II (Unidad 6 Colecciones)
            
            Random numeroRandom = new Random();
            List<int> listaNumerosAleatorios = new List<int>();
            Stack<int> pilaNumerosPositivos = new Stack<int>();
            Stack<int> pilaNumerosNegativos = new Stack<int>();
            Queue<int> colaNumerosPositivos = new Queue<int>();
            Queue<int> colaNumerosNegativos = new Queue<int>();

            //LISTAS

            for (int i=0;i<20;i++)
            {
                listaNumerosAleatorios.Add(numeroRandom.Next(-500, 500));
            }

            Console.WriteLine("Lista original sin ordenar");

            foreach (int numero in listaNumerosAleatorios)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("-----------");
            
            Console.WriteLine("Elementos positivos de la lista (orden decreciente)");
            listaNumerosAleatorios.Sort(OrdenarDecreciente);

            foreach (int numero in listaNumerosAleatorios)
            {
                if (numero >= 0)
                {
                    Console.WriteLine("{0}", numero);
                    colaNumerosPositivos.Enqueue(numero);
                }
                else 
                {
                    pilaNumerosNegativos.Push(numero);
                }
            }

            Console.WriteLine("-----------");

            Console.WriteLine("Elementos negativos de la lista (orden creciente)");
            listaNumerosAleatorios.Sort();
            foreach (int numero in listaNumerosAleatorios)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                    colaNumerosNegativos.Enqueue(numero);
                }
                else
                {
                    pilaNumerosPositivos.Push(numero);
                }
            }

            static int OrdenarDecreciente(int a, int b)
            {
                return b - a;
            }

            //PILAS

            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Elementos positivos de la pila (orden decreciente)");

            foreach (int numero in pilaNumerosPositivos)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("-----------");

            Console.WriteLine("Elementos negativos de la pila (orden creciente)");

            foreach (int numero in pilaNumerosNegativos)
            {
                Console.WriteLine(numero);
            }

            //COLAS

            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Elementos positivos de la cola (orden decreciente)");

            foreach (int numero in colaNumerosPositivos)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("-----------");

            Console.WriteLine("Elementos negativos de la cola (orden creciente)");

            foreach (int numero in colaNumerosNegativos)
            {
                Console.WriteLine(numero);
            }

            Console.ReadKey();

        }
    }
}
