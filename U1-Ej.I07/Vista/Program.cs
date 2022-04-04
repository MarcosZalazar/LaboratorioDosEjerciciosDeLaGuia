using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio I07 - Recibo de sueldo (Introduccion a .NET y C#)

            decimal valorHora;
            string nombre;
            int antiguedad;
            int cantidadDeHorasTrabajadas;
            char respuesta = ' ';
            decimal totalACobrarBruto;
            decimal totalACobrarNeto;

            do
            {
                Console.WriteLine("\nIngrese el nombre del empleado: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el valor hora: ");
                decimal.TryParse(Console.ReadLine(), out valorHora);
                Console.WriteLine("Ingrese la antiguedad en años: ");
                int.TryParse(Console.ReadLine(), out antiguedad);
                Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
                int.TryParse(Console.ReadLine(), out cantidadDeHorasTrabajadas);

                totalACobrarBruto = Empleado.CalcularSueldoBruto(valorHora, antiguedad, cantidadDeHorasTrabajadas);
                totalACobrarNeto = Empleado.CalcularSueldoNeto(totalACobrarBruto);

                Console.WriteLine("\nNombre: {0}, Antiguedad(en años): {1},Valor hora: {2},Total a cobrar bruto: {3}, Total a cobrar neto: {4}", nombre, antiguedad, valorHora, totalACobrarBruto, totalACobrarNeto);

                Console.WriteLine("\nDesea continuar? Ingrese 'S' para continuar o cualquier tecla para salir: ");
                respuesta = Console.ReadKey().KeyChar;

            } while (respuesta == 'S');

            Console.ReadKey();
        }
    }
}
