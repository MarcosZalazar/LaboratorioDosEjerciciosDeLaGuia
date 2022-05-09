using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random azar = new Random();
            Competencia formulaUno = new Competencia(10,5, Competencia.TipoCompetencia.F1);
            AutoF1[] autos = new AutoF1[10];

            for (int i = 0; i < autos.Length; i++)
            {
                autos[i] =new AutoF1((short)i, azar.Next(1,6).ToString());
                if ((formulaUno + autos[i]))
                {
                    Console.WriteLine("Se agregó el siguiente auto a la competencia:{0}", autos[i].MostrarDatos());

                }
                else
                {
                    Console.WriteLine("No se agregó ya que la competencia está completa:{0}", autos[i].MostrarDatos());
                }
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(formulaUno.MostrarDatos());

            Console.ReadKey();
        }
    }
}
