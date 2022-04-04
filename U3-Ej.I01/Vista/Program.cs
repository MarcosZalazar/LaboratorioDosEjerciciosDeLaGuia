using System;
using LogicaNegocio;


namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuentaQuebrado =new Cuenta("Marcos", 1000);

            cuentaQuebrado.Ingresar(800);
            Console.WriteLine(cuentaQuebrado.Mostrar());

            cuentaQuebrado.Retirar(300);
            Console.WriteLine(cuentaQuebrado.Mostrar());

            cuentaQuebrado.Ingresar(-400);
            Console.WriteLine(cuentaQuebrado.Mostrar());
        }
    }
}
