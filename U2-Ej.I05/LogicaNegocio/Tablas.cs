using System;
using System.Text;

namespace LogicaNegocio
{
    public static class Tablas
    {
        public static string tablaSolicitada;
        public static string DevolverTabla(int numero)
        {
            //Ejercicio I05 - Aprendete las tablas (Unidad 2 Clases y métodos estáticos)
            
            StringBuilder tabla;
            int resultado;
            int i;

            tabla = new StringBuilder();

            for (i = 1; i < 10; i++)
            {
                resultado = numero * i;
                tabla.AppendFormat($"{numero} X {i} = {resultado} ");
                tabla.Append(Environment.NewLine);
            }
            tablaSolicitada=tabla.ToString();

            return tablaSolicitada;
        }
    }
}
