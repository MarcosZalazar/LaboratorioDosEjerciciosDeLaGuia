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
            this.nombre = nombre;
            this.listadoVehiculos = new List<Vehiculo>(capacidad);
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


            }
        }

        public Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {


        }

        public string InformarSalida(Vehiculo vehiculo)
        {
            return vehiculo.;
        }
        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
        }
        public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
        }
        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
        }

    }
}
