using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I02 - ¿Desea continuar? (Unidad 2 Clases y métodos estáticos)

            int numeroIngresado;
            int acumuladorNumeros = 0;
            char respuesta;

            do
            {
                Console.WriteLine("\nIngrese un número: ");
                while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    Console.WriteLine("ERROR.Ingrese un número válido: ");

                }
                acumuladorNumeros = acumuladorNumeros + numeroIngresado;

                Console.WriteLine("Desea continuar? Ingrese 'S' para continuar o cualquier otra tecla para salir");
                respuesta = Console.ReadKey().KeyChar;

            } while (Validador.ValidarRespuesta(respuesta));

            Console.WriteLine("\n\nLa suma de los números ingresados es: {0} ", acumuladorNumeros);

            Console.ReadKey();
        }
    }
}
