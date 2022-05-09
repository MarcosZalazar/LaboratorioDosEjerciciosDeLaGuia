using System;
using Sobrescrito;

namespace Sobrescrito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I01 - Sobre-sobrescribiendo esas advertencias (Unidad 9 Polimorfismo)

            Console.Title = "Ejercicio Sobre-Sobrescrito";
            Sobrescrito objetoSobrescrito = new SobreSobrescrito();

            Console.WriteLine(objetoSobrescrito.MiMetodo());

            Console.WriteLine("----------------------------------------------");

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.ReadKey();
        }
    }
}
