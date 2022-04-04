using System;

namespace LogicaNegocio
{
    public static class Tiempos
    {
        public static int CalcularDiasVividos(DateTime fecha)
        {
            DateTime fechaActual;
            int cantidadDiasCalculados;

            fechaActual = DateTime.Now;
            cantidadDiasCalculados = fechaActual.Subtract(fecha).Days;

            return cantidadDiasCalculados;
        }
    }
}
