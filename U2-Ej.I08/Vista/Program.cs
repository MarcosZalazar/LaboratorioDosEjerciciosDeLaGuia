using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diaDeNacimiento;
            int mesDeNacimiento;
            int anioDeNacimiento;
            DateTime fechaDeNacimiento;
            int totalDiasVividos;
            

            Console.WriteLine("Ingrese su fecha de nacimiento(formato DD/MM/AAAA)");
            Console.WriteLine("Dia?: ");
            diaDeNacimiento = int.Parse(Console.ReadLine());
            Console.WriteLine("Mes?: ");
            mesDeNacimiento = int.Parse(Console.ReadLine());
            Console.WriteLine("Año: ");
            anioDeNacimiento = int.Parse(Console.ReadLine());

            fechaDeNacimiento = new DateTime(anioDeNacimiento, mesDeNacimiento, diaDeNacimiento);

            totalDiasVividos = Tiempos.CalcularDiasVividos(fechaDeNacimiento);

            Console.WriteLine("\nAl dia de la fecha, usted ha vivido {0} dias", totalDiasVividos);
            
            Console.ReadKey();
        }
    }
}
