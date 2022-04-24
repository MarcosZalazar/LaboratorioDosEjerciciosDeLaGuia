using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private string nombre;

        private Estacionamiento(string nombre, int capacidad)
        { 
            this.listadoVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
        }

        public List<Vehiculo> ListadoVehiculos
        {
            get
            {
                return listadoVehiculos;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if (estacionamiento is null)
            {
                estacionamiento = new Estacionamiento(nombre, capacidad);
            }
            else 
            {
                estacionamiento.capacidadEstacionamiento = capacidad;
            }
            return estacionamiento;
        }

        public string InformarSalida(Vehiculo vehiculo)
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del estacionamiento: {this.nombre}");
            sb.AppendLine($"Datos del vehículo:{vehiculo.ToString()}");
            sb.AppendLine($"{vehiculo.HoraEgreso}");
            sb.AppendLine($"{vehiculo.CostoEstadia}");

            return sb.ToString();
        }
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento is not null && vehiculo is not null)
            {
                foreach (Vehiculo vehiculoAevaluar in estacionamiento.listadoVehiculos)
                {
                    if (vehiculoAevaluar.Descripcion== vehiculo.Descripcion) 
                    { 
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento==vehiculo);
        }
        public static bool operator + (Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento.capacidadEstacionamiento>0 && estacionamiento!= vehiculo)
            {
                estacionamiento.listadoVehiculos.Add(vehiculo);
                return true;
            }
            return false;
        }
        public static bool operator - (Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento == vehiculo)
            {
                vehiculo.HoraEgreso = DateTime.Now;
                estacionamiento.listadoVehiculos.Remove(vehiculo);
                return true;
            }
            return false;
        }
    }
}
