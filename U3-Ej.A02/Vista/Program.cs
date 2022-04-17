using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio A02 - La veterinaria (Unidad 3 Programación Orientada a Objetos)

            Cliente fulano = new Cliente("Calle falsa 123","Pepito","Fulano","15 123456");
            Mascota perro1 = new Mascota("perro", "fatiga", new DateTime(1985, 05, 31));
            fulano.SetMascota(0, perro1);

            Cliente mengano = new Cliente("Calle falsa 456", "Pedro", "Mengano", "15 98765");
            Mascota gato1 = new Mascota("gato", "Salem", new DateTime(1985, 05, 31));
            gato1.SetVacunas(0,"Triple Felina");
            mengano.SetMascota(0, gato1);

            Cliente sultano = new Cliente("Calle falsa 789", "Juan", "Sultano", "15 564578");
            Mascota gato2 = new Mascota("gato", "Garfield", new DateTime(1987, 05, 29));
            Mascota perro2 = new Mascota("perro", "Lazy", new DateTime(1980, 05, 31));
            perro2.SetVacunas(0, "Antirábica");
            sultano.SetMascota(0, gato2);
            sultano.SetMascota(1, perro2);

            Console.WriteLine(fulano.GetInfoCompletaCliente());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(mengano.GetInfoCompletaCliente());
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(sultano.GetInfoCompletaCliente());

            Console.ReadKey();

        }
    }
}
