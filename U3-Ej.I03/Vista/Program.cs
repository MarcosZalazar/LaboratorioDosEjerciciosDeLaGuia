using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I03 - El ejemplo universal (Unidad 3 Programación orientada a objetos)

            Estudiante estudianteUno = new Estudiante("Miguel", "Luna" , "1000");
            Estudiante estudianteDos = new Estudiante("Juan", "Lopez", "1001");
            Estudiante estudianteTres = new Estudiante("Pepito", "Perez", "1005");

            estudianteUno.SetNotaPrimerParcial(9);
            estudianteUno.SetNotaSegundoParcial(10);
            estudianteDos.SetNotaPrimerParcial(7);
            estudianteDos.SetNotaSegundoParcial(4);
            estudianteTres.SetNotaPrimerParcial(2);
            estudianteTres.SetNotaSegundoParcial(3);


            Console.WriteLine(estudianteUno.Mostrar());
            Console.WriteLine(estudianteDos.Mostrar());
            Console.WriteLine(estudianteTres.Mostrar());
            Console.WriteLine("\n");
        }
    }
}
