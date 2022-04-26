using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private List<Equipo> equipos;
        private string nombre;
        private int cantidaCompetidores;

        /// <summary>
        /// Constuctor privado de torneo que se va a usar desde la convercion implicita de string
        /// Por defecto cantidad de competidores es cero
        /// </summary>
        /// <param name="nombre"></param>
        private Competencia(string nombre)
            :this(nombre,5)
        {
                        
        }

        /// <summary>
        /// Constructor public de torneo que recibe todos los parametros e inicializa la lista
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="cantidadCompetidores"></param>
        public Competencia(string nombre, int cantidadCompetidores)
        {
            this.equipos = new List<Equipo>();
            this.nombre = nombre;
            this.cantidaCompetidores = cantidadCompetidores;
        }

        public int CantidaCompetidores { get => this.cantidaCompetidores;set { this.cantidaCompetidores = value > 0 ? value : 0; } }

        public string Nombre { get => nombre; set => nombre = value; }
        public List<Equipo> Equipos { get => this.equipos;}


        /// <summary>
        /// Conversion implicita de string a torneo que devuelve una instancia con el nombre asignado.
        /// Llama al constructor privado y por defecto no asigna competidores.
        /// </summary>
        /// <param name="nombre"></param>

        public static implicit operator Competencia (string nombre)
        {
            return new Competencia(nombre);
        }

        /// <summary>
        /// Un torneo y un equipo son iguales si este equipo este en el torneo, se compara por == (seria nombre y categoria)
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static bool operator == (Competencia torneo, Equipo equipo)
        {
            //foreach (Equipo item in torneo.Equipos)
            //{
            //    if(item == equipo)
            //    {
            //        return  true;
            //    }
            //}

            //return false;
            return torneo.Equipos.Exists(element => element == equipo);
        }
        public static bool operator !=(Competencia torneo, Equipo equipo)
        {
            return !(torneo==equipo);
        }

        /// <summary>
        /// Se podra agregar un equipo al torneo si este cuenta con capacidad y este no se encuenta ya en el torneo
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static Competencia operator + (Competencia torneo, Equipo equipo)
        {
            if (torneo != equipo && torneo.CantidaCompetidores > torneo.equipos.Count)
            {
                torneo.Equipos.Add(equipo);
            }

            return torneo;
        }


        /// <summary>
        /// Metodo de clase que expone los datos del torneo y sus equipos (basquet y futbol).
        /// </summary>
        /// <param name="torneo"></param>
        /// <returns></returns>
        public static string MostrarTorneo(Competencia torneo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Competencia: {torneo.nombre}");
            sb.AppendLine($"Cantidad de Competidores: {torneo.equipos.Count}/{torneo.cantidaCompetidores}");

            torneo.Equipos.ForEach(element => sb.AppendLine(element.ToString()));
            return sb.ToString();
            
        }

        


    }
}
