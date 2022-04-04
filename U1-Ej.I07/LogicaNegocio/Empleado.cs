using System;

namespace LogicaNegocio
{
    public class Empleado
    {
        public static decimal totalBruto;
        public static decimal totalNeto;

        public static decimal CalcularSueldoBruto(decimal valorHora, int antiguedad, int cantidadDeHorasTrabajadas)
        {
            totalBruto = (valorHora * cantidadDeHorasTrabajadas) + (150 * antiguedad);

            return totalBruto;
        }
        public static decimal CalcularSueldoNeto(decimal totalACobrarBruto)
        {
            totalNeto = totalACobrarBruto - ((totalACobrarBruto * 13) / 100);

            return totalNeto;
        }
    }
}
