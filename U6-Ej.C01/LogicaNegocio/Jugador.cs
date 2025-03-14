﻿using System;
using System.Text;

namespace LogicaNegocio
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0.0f;
            this.totalGoles = 0;
        }
        public Jugador(int dni, string nombre): this()
        {
            this.dni = dni;
            this.nombre = nombre;   
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni,nombre)
        {
            this.totalGoles=totalGoles;
            this.partidosJugados=totalPartidos; 
        }

        public float GetPromedioGoles()
        {
            return (float)this.totalGoles / this.partidosJugados;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();  

            sb.AppendLine("Nombre: " + this.nombre);
            sb.AppendLine("Dni: " + this.dni.ToString());
            sb.AppendLine("Total de goles: " + this.totalGoles.ToString());
            sb.AppendLine("Partidos jugados: " + this.partidosJugados.ToString());
            sb.AppendLine("Promedio de goles: " + this.GetPromedioGoles().ToString());

            return sb.ToString();   
        }

        public static bool operator == (Jugador j1, Jugador j2)
        {
            if (j1 is not null && j2 is not null)
            {
                if (j1.dni==j2.dni)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator != (Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
