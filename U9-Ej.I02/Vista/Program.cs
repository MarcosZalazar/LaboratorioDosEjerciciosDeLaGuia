﻿using System;
using System.Collections.Generic;
using System.Text;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I02 - Calculadora de formas (Unidad 9 Polimorfismo)

            List<Figura> figuras = new List<Figura>();

            figuras.Add(new Circulo(2));
            figuras.Add(new Cuadrado(3));
            figuras.Add(new Rectangulo(4, 8));

            StringBuilder sb = new StringBuilder();

            foreach (Figura figura in figuras)
            {
                sb.AppendLine();
                sb.AppendFormat("=============== FIGURA {0:0#} ==================\n", figuras.IndexOf(figura) + 1);
                sb.AppendFormat(" Tipo: {0}\n", figura.GetType());
                sb.AppendFormat(" {0}\n", figura.Dibujar());
                sb.AppendFormat(" Área: {0:0.00}\n", figura.CalcularSuperficie());
                sb.AppendFormat(" Perímetro: {0:0.00}\n", figura.CalcularPerimetro());
                sb.AppendLine("============================================");
                sb.AppendLine();
            }

            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
