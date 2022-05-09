using System;

namespace LogicaNegocio
{
    public static class Calculador
    {
        public static int Calcular(int primerEntero, int segundoEntero )
        {
            int resultado=0;

            try
            {
                resultado=primerEntero / segundoEntero;
            }
            catch (Exception)
            {
                throw new ParametrosVaciosException("No se puede dividir por cero");
            }
            return resultado;
        }
    }
}
