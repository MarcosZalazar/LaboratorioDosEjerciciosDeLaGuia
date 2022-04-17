using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Mascota
    {
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        private string[] historialVacunacion = new string[4];

        public Mascota(string especie, string nombre, DateTime fechaNacimiento)
        {
            this.especie = especie;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            for (int i = 0; i < historialVacunacion.Length; i++)
            {
                this.historialVacunacion[i] = "";
            }
        }

        public string GetEspecie()
        {
            return this.especie;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public DateTime GetFechaNacimiento()
        {
            return this.fechaNacimiento;
        }
        public string GetVacunas()
        {
            StringBuilder vacunasAMostrar = new StringBuilder();

            for (int i = 0; i < historialVacunacion.Length; i++)
            {
                if (historialVacunacion is not null)
                {
                    vacunasAMostrar.Append(historialVacunacion[i]);
                }
            }
            return vacunasAMostrar.ToString();
        }
        public string GetInfoCompletaMascota()
        {
            return $"Especie:{GetEspecie()} Nombre:{GetNombre()} Fecha de nacimiento:{GetFechaNacimiento()} Vacunas:{GetVacunas()}\n";
        }

        public void SetEspecie(string especie)
        {
            this.especie=especie;   
        }
        public void SetNombre(string nombre)
        {
            this.nombre=nombre;
        }
        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento=fechaNacimiento;
        }
        public void SetVacunas(int indice, string vacunas)
        {
            this.historialVacunacion[indice] = vacunas;
        }

    }
}
