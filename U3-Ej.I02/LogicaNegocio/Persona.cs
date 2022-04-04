using System;


namespace LogicaNegocio
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        { 
            return this.nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre=nombre;
        }

        public DateTime GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }

        public void SetFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento= fechaDeNacimiento;
        }

        public string GetDni()
        {
            return this.dni;
        }


        public void SetDni(string dni)
        {
            this.dni = dni;
        }

        private double CalcularEdad()
        {
            DateTime fechaNacimiento = this.fechaDeNacimiento;
            DateTime fechaActual=DateTime.Now;
            TimeSpan diferenciaDias;
            double edad;

            diferenciaDias = fechaActual - fechaNacimiento;
            edad =Math.Floor(diferenciaDias.TotalDays/365);

            return edad;
        }

        public string Mostrar()
        {
                return $"Nombre:{nombre}, fecha de Nacimiento:{fechaDeNacimiento.ToString("MM/dd/yyyy")} y dni:{dni}";
        }

        public string EsMayorDeEdad()
        {
            string mensaje;
            double edad;

            edad = CalcularEdad();

            if (edad >= 18)
            {
                mensaje = "es mayor de edad";
            }
            else 
            {
                mensaje = "es menor";
            }

            return mensaje;
        }
    }
}
