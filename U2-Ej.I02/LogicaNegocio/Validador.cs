using System;

namespace LogicaNegocio
{
    public class Validador
    {
        public static bool ValidarRespuesta(char respuestaAEvaluar)
        {
            bool continuar;

            continuar = false;

            if (respuestaAEvaluar == 'S')
            {
                continuar = true;
            }
            return continuar;
        }
    }
}
