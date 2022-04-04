using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I06 - Calculadora de áreas (Unidad 2 Clases y métodos estáticos)

            char respuesta;
            double ladoCuadrado;
            double baseTriangulo;
            double alturaTriangulo;
            double radioCirculo;
            double areaCalculada;
            

            Console.WriteLine("El area de que figura geométrica desea calcular? Elija Q (cuadrado), T (triángulo) y C (círculo)");
            respuesta=Console.ReadKey().KeyChar;

            switch (respuesta)
            {
                case 'Q':
                    Console.WriteLine("\nIngrese la longitud del lado");
                    double.TryParse(Console.ReadLine(),out ladoCuadrado);
                    areaCalculada =CalculadoraDeArea.CalcularAreaCuadrado(ladoCuadrado);
                    Console.WriteLine($"\nEl área del cuadrado es {areaCalculada}");
                    break;

                case 'T':
                    Console.WriteLine("\nIngrese la base del triángulo");
                    double.TryParse(Console.ReadLine(), out baseTriangulo);
                    Console.WriteLine("\nIngrese la altura del triángulo");
                    double.TryParse(Console.ReadLine(), out alturaTriangulo);
                    areaCalculada = CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo,alturaTriangulo);
                    Console.WriteLine($"\nEl área del triángulo es {areaCalculada}");
                    break;

                case 'C':
                    Console.WriteLine("\nIngrese el radio del círculo");
                    double.TryParse(Console.ReadLine(), out radioCirculo);
                    areaCalculada = CalculadoraDeArea.CalcularAreaCirculo(radioCirculo);
                    Console.WriteLine($"\nEl área del círculo es {areaCalculada}");
                    break;

                default:
                    Console.WriteLine("\nRespuesta inválida. Ingrese Q (cuadrado), T (triángulo) y C (círculo)");
                    break;
            }

            Console.ReadKey();
        }
    }
}
