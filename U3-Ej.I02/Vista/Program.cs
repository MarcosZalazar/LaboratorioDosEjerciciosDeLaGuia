using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I02 - ¿Vos cuántas primaveras tenés? (Unidad 3 Programación orientada a objetos)

            Persona personaUno=new Persona("Miguel",new DateTime(2020,04,03),"45.062.744");
            Persona personaDos= new Persona("Juan", new DateTime(1985,06,20), "31.662.694");
            Persona personaTres= new Persona("Pepito", new DateTime(1996,05,01), "38.272.165");

            Console.WriteLine(personaUno.Mostrar());
            Console.WriteLine(personaDos.Mostrar());
            Console.WriteLine(personaTres.Mostrar());
            Console.WriteLine("\n");

            Console.WriteLine($"{personaUno.GetNombre()} {personaUno.EsMayorDeEdad()}");
            Console.WriteLine($"{personaDos.GetNombre()} {personaDos.EsMayorDeEdad()}");
            Console.WriteLine($"{personaTres.GetNombre()} {personaTres.EsMayorDeEdad()}");

        }
    }
}
