using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kmsComparativoConductor1=int.MinValue;
            int kmsComparativoConductor2 = int.MinValue;
            int kmsComparativoConductor3 = int.MinValue;

            Conductor conductor1 = new Conductor("Marcos","Juarez");
            int[] kilometrosConductor1 = new int[7] { 200, 599, 899, 0, 526, 0, 0};

            Conductor conductor2 = new Conductor("Lucas", "Perez");
            int[] kilometrosConductor2 = new int[7] { 100, 300, 741, 200, 30, 40, 0 };

            Conductor conductor3 = new Conductor("Pablo", "Miguens");
            int[] kilometrosConductor3 = new int[7] { 0, 150, 299, 70, 0, 123, 83 };

            kmsComparativoConductor1 = conductor1.GetKilometrosRecorridosPorDia(3);
            kmsComparativoConductor2 = conductor2.GetKilometrosRecorridosPorDia(3);
            kmsComparativoConductor3 = conductor3.GetKilometrosRecorridosPorDia(3);

            if (kmsComparativoConductor1 > kmsComparativoConductor2 && kmsComparativoConductor1 > kmsComparativoConductor3)
            { 

            }
        }
    }
}
