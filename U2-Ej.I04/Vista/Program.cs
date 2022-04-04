using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I04 - La calculadora (Unidad 2 Clases y métodos estáticos)

            char continuar =' ';
            decimal primerOperando;
            decimal segundoOperando;
            decimal resultado;
            char Operacion;

            Console.WriteLine("Bienvenido a la calculadora de la UTN");
            do
            {
                Console.WriteLine("\nIngrese el primer operando: ");
                decimal.TryParse(Console.ReadLine(),out primerOperando);
               
                Console.WriteLine("Ingrese el segundo operando:");
                decimal.TryParse(Console.ReadLine(), out segundoOperando);
            
                Console.WriteLine("Ingrese la operación (+,-,*,/)");
                Operacion = Console.ReadKey().KeyChar;

                resultado = Calculadora.Calcular(primerOperando, segundoOperando, Operacion);
                Console.WriteLine("\nEl resultado es: {0}",resultado);

                Console.WriteLine("Ingrese S para realizar otra operación o cualquier otra tecla para salir");
                continuar=Console.ReadKey().KeyChar;

            } while (continuar=='S');

            Console.ReadKey();
        }
    }
}
