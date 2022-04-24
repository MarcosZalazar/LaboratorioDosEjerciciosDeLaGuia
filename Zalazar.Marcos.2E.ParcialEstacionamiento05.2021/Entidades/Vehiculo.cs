using System;
using System.Text;

namespace Entidades
{
    public enum Evehiculos
    { 
        Automovil,
        Moto
    }
    public abstract class Vehiculo
    {
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;

        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.patente = Patente;
            this.horaIngreso = horaIngreso;
        }

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if (value.Length>6 && value.Length < 7) 
                {
                    this.patente = value;
                }
            }
        }
        public abstract double CostoEstadia
        {
            get;

        }

        public abstract string Descripcion
        {
            get;
  
        }
        public DateTime HoraEgreso
        {
            get
            {
                return this.horaEgreso;

            }
            set
            {
                if (this.horaEgreso>horaIngreso) 
                {
                    this.horaEgreso = value;
                } 
            }
        }
        public DateTime HoraIngreso
        {
            get
            {
                return this.horaIngreso;

            }
            set
            {
                this.horaIngreso = value;
            }
        }

        protected virtual double CargoDeEstacionamiento() 
        { 

        
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb=new StringBuilder();

            sb.Append($"Patente: {this.Patente} Hora de ingreso{this.HoraIngreso}");

            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        { 
            return v1 is not null && v2 is not null && v1.patente==v2.patente;  
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        private bool ValidarPatente(string patente)
        {
            return patente==(this.Patente);    
        }
    }
}
