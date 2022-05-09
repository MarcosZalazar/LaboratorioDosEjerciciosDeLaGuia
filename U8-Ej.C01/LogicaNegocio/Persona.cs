using System;
using System.Text;

namespace LogicaNegocio
{
    public class Persona
    {
        private long dni;
        private string nombre;

        public Persona(long dni, string nombre):this(nombre)
        {
            this.dni = dni;
        }
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public long Dni 
        {
            get 
            { 
                return this.dni; 
            }
            set 
            { 
                this.dni = value; 
            }    
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Dni: " + this.Dni.ToString());

            return sb.ToString();
        }
    }
}
