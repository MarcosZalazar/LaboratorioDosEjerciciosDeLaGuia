using System;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binario;
            bool esBinario = true;

            binario = "1010";

            for (int i = 0; i < binario.Length; i++)
            {
                if (binario[i] != '0' && binario[i] != '1')
                {
                    esBinario = false;
                    break;
                }
            }
            
            Console.WriteLine("{0}", esBinario);
            Console.WriteLine("{0}", binario);
        }
    }
}
