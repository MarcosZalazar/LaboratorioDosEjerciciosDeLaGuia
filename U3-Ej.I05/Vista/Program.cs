using System;
using Geometria;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I05 - Prueba de geometría (Unidad 3 Programación orientada a objetos)

            Punto verticeUno= new Punto (1,5);
            Punto verticeTres= new Punto (4, 7);
            Rectangulo rectanguloAMostrar = new Rectangulo(verticeUno, verticeTres);

            MostrarInfoRectangulo(rectanguloAMostrar);

            Console.WriteLine("-------------------------------------");

            Punto verticeUno2 = new Punto(-1, 5);
            Punto verticeTres2 = new Punto(-4, 7);
            Rectangulo rectanguloAMostrar2 = new Rectangulo(verticeUno2, verticeTres2);

            MostrarInfoRectangulo(rectanguloAMostrar2);

            Console.ReadKey();

            static void MostrarInfoRectangulo(Rectangulo rectangulo)
            {
                Console.WriteLine("El vertice 1 es el punto: X={0} y Y={1}", (rectangulo.GetVertice1()).GetX(), (rectangulo.GetVertice1()).GetY());
                Console.WriteLine("El vertice 2 es el punto: X={0} y Y={1}", (rectangulo.GetVertice2()).GetX(), (rectangulo.GetVertice2()).GetY());
                Console.WriteLine("El vertice 3 es el punto: X={0} y Y={1}", (rectangulo.GetVertice3()).GetX(), (rectangulo.GetVertice3()).GetY());
                Console.WriteLine("El vertice 4 es el punto: X={0} y Y={1}", (rectangulo.GetVertice4()).GetX(), (rectangulo.GetVertice4()).GetY());
                Console.WriteLine("El area del rectangulo es: {0}", rectangulo.Area());
                Console.WriteLine("El perimetro del rectangulo es: {0}", rectangulo.Perimetro());
            }
        }
    }
}
