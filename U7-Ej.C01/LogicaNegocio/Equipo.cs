using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if ((e is not null && j is not null) && (e.jugadores.Count < e.cantidadDeJugadores))
            {
                foreach (Jugador jugador in e.jugadores)
                {
                    if (jugador == j)
                    {
                        return false;
                    }
                }
                e.jugadores.Add(j);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
