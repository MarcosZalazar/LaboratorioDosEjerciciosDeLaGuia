using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I04 - Invento argentino (Unidad 3 Programación orientada a objetos)
            string mensaje1;
            string mensaje2;

            Boligrafo boligrafoAzul = new Boligrafo(100,ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            Console.WriteLine("El nivel de tinta inicial del boligrafo azul es: {0}",boligrafoAzul.GetTinta());
            Console.WriteLine("El nivel de tinta inicial del boligrafo rojo es: {0}", boligrafoRojo.GetTinta());
            Console.WriteLine("-------------------");

            Console.ForegroundColor = boligrafoAzul.GetColor();
            boligrafoAzul.Pintar(-40,out mensaje1);
            Console.WriteLine("Mensaje impreso: {0}", mensaje1);

            Console.ForegroundColor= boligrafoRojo.GetColor();
            boligrafoRojo.Pintar(-60, out mensaje2);
            Console.WriteLine("Mensaje impreso: {0}", mensaje2);

            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("El nivel de tinta actual del boligrafo azul es: {0}", boligrafoAzul.GetTinta());
            Console.WriteLine("El nivel de tinta actual del boligrafo rojo es: {0}", boligrafoRojo.GetTinta());
            Console.WriteLine("-------------------");

            boligrafoAzul.Recargar();
            boligrafoRojo.Recargar();

            Console.WriteLine("El nivel de tinta final del boligrafo azul es: {0}", boligrafoAzul.GetTinta());
            Console.WriteLine("El nivel de tinta final del boligrafo rojo es: {0}", boligrafoRojo.GetTinta());

            Console.ReadKey();  
        }
    }
}
