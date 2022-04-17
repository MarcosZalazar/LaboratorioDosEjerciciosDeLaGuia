using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio C01 - Conversor binario recargado(Unidad 4 Sobrecarga)

            NumeroBinario numeroBinario = (NumeroBinario)"1001";
            NumeroDecimal numeroDecimal = (NumeroDecimal)9;

            Console.WriteLine($"El número binario es {numeroBinario.Numero}, sumado con el decimal da un total de {numeroDecimal+numeroBinario}");
            
            Console.WriteLine($"El número decimal es {numeroDecimal.Numero}, sumado con el binario da un total de {numeroBinario + numeroDecimal}");

            Console.ReadKey();
        }
    }
}
