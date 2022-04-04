using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I03 - Conversor binario (Unidad 2 Clases y métodos estáticos)

            char respuestaChar;
            int numeroDecimalAConvertir;
            string numeroBinarioAConvertir;
            int numeroDecimalConvertido;
            string numeroBinarioConvertido;

            Console.WriteLine("Conversor de números. Ingrese D si desea convertir su número de decimal a binario, o B si desea convertir su número de binario a decimal");
            respuestaChar=Console.ReadKey().KeyChar;

            switch (respuestaChar)
            {
                case 'D':
                    Console.WriteLine("Ahora ingrese un número entero decimal a convertir: ");
                    int.TryParse(Console.ReadLine() ,out numeroDecimalAConvertir);
                    numeroBinarioConvertido=Conversor.ConvertirDecimalABinario(numeroDecimalAConvertir);
                    Console.WriteLine("El número {0} convertido a binario es {1}: ", numeroDecimalAConvertir, numeroBinarioConvertido); ;
                    break;

                case 'B':
                    Console.WriteLine("Ahora ingrese un número binario a convertir: ");
                    numeroBinarioAConvertir=Console.ReadLine();
                    numeroDecimalConvertido = Conversor.ConvertirBinarioADecimal(numeroBinarioAConvertir);
                    Console.WriteLine("El número {0} convertido a decimal es {1}: ", numeroBinarioAConvertir, numeroDecimalConvertido);
                    break;

                default:
                    Console.WriteLine("Repuesta inválida. Ingrese D o B");
                    break;
            }

            Console.ReadKey();
        }
    }
}
