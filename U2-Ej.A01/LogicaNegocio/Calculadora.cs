using System;
using LogicaNegocio;

namespace LogicaNegocio
{
    public static class Calculadora
    {
        public static int resultado;
        public static int CalcularFactorial(int numero)
        {
            int i;

            if (numero < 0)
            {
                resultado = -1;
            }
            else 
            {
                if (numero == 0)
                {
                    resultado = 1;
                }
                else 
                {
                    resultado = 1;
                    for (i= 1;i <= numero; i++)
                    {
                        resultado = resultado * i;
                    }
                }
            }
            return resultado;
        }
    }
}
