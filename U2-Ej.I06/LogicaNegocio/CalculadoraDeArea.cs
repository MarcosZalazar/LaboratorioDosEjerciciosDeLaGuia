using System;

namespace LogicaNegocio
{
    public static class CalculadoraDeArea
    {
        public static double area;
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            area= longitudLado*longitudLado;

            return area;
        }
        public static double CalcularAreaTriangulo(double baseTriangulo, double altura) 
        {
            area = (baseTriangulo * altura)/2;

            return area;
        }
        
        public static double CalcularAreaCirculo(double radio) 
        {
            area = (Math.PI)*(Math.Pow(radio, 2));

            return area;
        }
    }
}
