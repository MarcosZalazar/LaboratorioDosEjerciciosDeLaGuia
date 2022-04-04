using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio A01 - Calcular un factorial (Unidad 2 Clases y métodos estáticos)

            int numeroIngresado;
            int factorial;

            Console.WriteLine("Ingrese un número entero positivo");
            int.TryParse(Console.ReadLine(), out numeroIngresado);

            factorial = Calculadora.CalcularFactorial(numeroIngresado);

            if (factorial < 0)
            {
                Console.WriteLine("No se puede calcular el factorial de un número negativo");
            }
            else
            {
                Console.WriteLine($"El factorial de {numeroIngresado} es {factorial}");
            }
        }
    }
}
