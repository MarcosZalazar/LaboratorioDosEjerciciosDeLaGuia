using System;

namespace LogicaNegocio
{
    public static class Conversor
    {
        public static string numeroBinario;
        public static int numeroDecimal;

        public static string ConvertirDecimalABinario(int numero)
        {
            string valorBinario = string.Empty;
            int resultDiv = numero;
            int restoDiv;

            if (resultDiv >= 0)
            {
                do
                {
                    restoDiv = resultDiv % 2;
                    resultDiv /= 2;
                    valorBinario = restoDiv.ToString() + valorBinario;
                } while (resultDiv > 0);
            }
            return valorBinario;
        }
        public static string ConvertirDecimalABinario2(int numeroEntero)
        {
            numeroBinario = Convert.ToString(numeroEntero, 2);

            return numeroBinario;
        }

        public static int ConvertirBinarioADecimal(string valorRecibido)
        {
            int resultado = 0;
            int cantidadCaracteres = valorRecibido.Length;

            foreach (char caracter in valorRecibido)
            {
                cantidadCaracteres--;
                if (caracter == '1')
                {
                    resultado += (int)Math.Pow(2, cantidadCaracteres);

                }
            }
            return resultado;
        }

        public static int ConvertirBinarioADecimal2(string numeroEntero)
        {
            numeroDecimal = Convert.ToInt32(numeroEntero, 2);

            return numeroDecimal;
        }
    }
}
