using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I01 - Validador de rangos (Unidad 2 Clases y métodos estáticos)

            string numeroIngresadoString;
            int numeroIngresado;
            int i;
            int numeroMaximo = int.MinValue;
            int numeroMinimo = int.MaxValue;
            int acumuladorNumero = 0;
            double promedioNumeros;

            for (i = 0; i < 10; i++)
            {

                do
                {
                    Console.WriteLine("Ingrese un número");
                    numeroIngresadoString = Console.ReadLine();

                } while (!int.TryParse(numeroIngresadoString, out numeroIngresado) || !Validador.Validar(numeroIngresado, -100, 100));

                if (i == 0)
                {
                    numeroMaximo = numeroIngresado;
                    numeroMinimo = numeroIngresado;
                }
                else
                {
                    if (numeroIngresado > numeroMaximo)
                    {
                        numeroMaximo = numeroIngresado;
                    }
                    if (numeroIngresado < numeroMinimo)
                    {
                        numeroMinimo = numeroIngresado;
                    }
                }
                acumuladorNumero = acumuladorNumero + numeroIngresado;

            }
            promedioNumeros = acumuladorNumero / i;

            Console.WriteLine("El número máximo ingresado es {0,0:#.###,00}, el mínimo es {1,0:#.###,00} y el promedio es {2,0:#.###,00}", numeroMaximo, numeroMinimo, promedioNumeros);

            Console.ReadKey();
        }
    }
}
