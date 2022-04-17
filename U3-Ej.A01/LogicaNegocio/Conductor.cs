using System;


namespace LogicaNegocio
{
    public class Conductor
    {
        private string nombre;
        private string apellido;
        private int[] kilometrosRecorridosPorDia;

        public Conductor(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;

            for (int i=0; i<this.kilometrosRecorridosPorDia.Length; i++)
            {
                this.kilometrosRecorridosPorDia[i] = 0;

            }
        }

        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetApellido()
        {
            return this.apellido;
        }
        public int GetKilometrosRecorridosPorDia(int dia)
        {
            return this.kilometrosRecorridosPorDia[dia];
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
            
        }
        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void SetKilometrosRecorridosPorDia(int dia, int kilometros)
        {
            this.kilometrosRecorridosPorDia[dia] = kilometros;
        }

        public int CalcularKilometrosPorSeman() 
        {
            int kilometrosPorSemana=int.MinValue;

            for(int i=0; i< kilometrosRecorridosPorDia.Length; i++) 
            {

                kilometrosPorSemana = kilometrosRecorridosPorDia[i]+ kilometrosPorSemana;
            }

            return kilometrosPorSemana;
        }
    }
}
