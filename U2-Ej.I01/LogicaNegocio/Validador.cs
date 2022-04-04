using System;

namespace LogicaNegocio
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool estaEnElRango = false;

            if (valor >= min && valor <= max)
            {
                estaEnElRango = true;
            }
            return estaEnElRango;
        }
    }
}
