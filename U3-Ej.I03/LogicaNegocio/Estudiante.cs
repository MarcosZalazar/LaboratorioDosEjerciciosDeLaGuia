using System;
using System.Text;

namespace LogicaNegocio
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        public double CalcularNotaFinal()
        {
            double notaFinal;

            if (this.notaPrimerParcial>=4 && this.notaSegundoParcial >= 4)
            {
                notaFinal=Estudiante.random.Next(6, 10);
            }
            else 
            {
                notaFinal = -1;
            }
            return notaFinal; 
        }

        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial+this.notaSegundoParcial)/ 2;
        }

        static Estudiante()
        {
            Estudiante.random= new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        public string Mostrar()
        {
            StringBuilder mensajeCompleto;
            string mensaje;

            mensajeCompleto = new StringBuilder();

            mensajeCompleto.AppendFormat($"Alumno: {this.nombre} {this.apellido} Legajo: {this.legajo} Nota del primer pacial:{this.notaPrimerParcial} Nota del segundo pacial:{this.notaSegundoParcial} Promedio {CalcularPromedio()}");
            if (CalcularNotaFinal() == -1)
            {
                mensajeCompleto.Append(" Nota final:Alumno desaprobado");
            }
            else
            {
                mensajeCompleto.AppendFormat($" Nota final:{CalcularNotaFinal()}");
            }

            mensajeCompleto.Append(Environment.NewLine);
            mensaje = mensajeCompleto.ToString();

            return mensaje;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }


    }
}
