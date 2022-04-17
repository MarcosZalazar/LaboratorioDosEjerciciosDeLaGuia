using System;
using System.Text;

namespace LogicaNegocio
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad) 
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        public string Mostrar()
        {
            StringBuilder mensajeArmado = new StringBuilder();
            string mensajeCompleto;

            mensajeArmado.AppendLine($"Nombre:{this.nombre}");
            mensajeArmado.AppendLine($"Direccion:{this.direccion}");
            mensajeArmado.AppendLine($"Edad:{this.edad}");
            mensajeArmado.AppendLine($"Género:{this.genero}");
            mensajeArmado.AppendLine($"País:{this.pais}");
            mensajeArmado.Append($"Cursos: ");
            for (int i = 0; i < cursos.Length; i++)
            {
                mensajeArmado.Append($"{cursos[i]} ");
            }

            mensajeCompleto=mensajeArmado.ToString();

            return mensajeCompleto;
        }   
    }
}
