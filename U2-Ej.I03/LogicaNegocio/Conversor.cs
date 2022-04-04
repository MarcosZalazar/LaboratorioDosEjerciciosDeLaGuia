using System;

namespace LogicaNegocio
{
    public static class Conversor
    {
        public static string numeroBinario;
        public static int numeroDecimal;

        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            numeroBinario = Convert.ToString(numeroEntero, 2);

            return numeroBinario;
        }

        public static int ConvertirBinarioADecimal(string numeroEntero)
        {
            numeroDecimal = Convert.ToInt32(numeroEntero, 2);

            return numeroDecimal;
        }
    }
}
