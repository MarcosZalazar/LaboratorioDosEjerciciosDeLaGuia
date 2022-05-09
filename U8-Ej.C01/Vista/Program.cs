using LogicaNegocio;
using System;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio C01 - Herencia deportiva (Unidad 8 Herencia)

            Equipo equipo = new Equipo(2, "utn");
            Jugador j1 = new Jugador(123, "nom1", 5, 20);
            Jugador j2 = new Jugador(485, "nom2", 3, 5);
            Jugador j3 = new Jugador(123, "nom3", 7, 3);
            Jugador j4 = new Jugador(789, "nom4", 3, 5);

            if (equipo + j1)
            {
                Console.WriteLine(j1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGÓ " + j1.MostrarDatos());
            }

            if (equipo + j2)
            {
                Console.WriteLine(j2.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGÓ " + j2.MostrarDatos());
            }

            if (equipo + j3)
            {
                Console.WriteLine(j3.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGÓ " + j3.MostrarDatos());
            }
            if (equipo + j4)
            {
                Console.WriteLine(j4.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGÓ " + j4.MostrarDatos());
            }

            Console.ReadKey();
        }
    }
}
