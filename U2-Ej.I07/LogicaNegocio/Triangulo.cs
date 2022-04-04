using System;

namespace LogicaNegocio
{
    public static class Triangulo
    {
        public static double hipotenusa;
        public static double CalcularHipotenusa(double catetoUno, double catetoDos)
        {
            hipotenusa = Math.Sqrt((Math.Pow(catetoUno, 2)+ Math.Pow(catetoDos, 2)));

            return hipotenusa;
        }
    }
}
