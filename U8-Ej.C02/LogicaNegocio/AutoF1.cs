﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class AutoF1: VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        public AutoF1(short numero,string escuderia):base(numero,escuderia)
        {
            
        }
        public AutoF1(short numero, string escuderia, short caballosDeFuerza):this(numero,escuderia)    
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Caballos de fuerza: " + this.CaballosDeFuerza);

            return sb.ToString();
        }

        public static bool operator == (AutoF1 a1, AutoF1 a2)
        {
            if (a1 is not null && a2 is not null)
            {
                if (((VehiculoDeCarrera)a1== (VehiculoDeCarrera)a2) && (a1.CaballosDeFuerza==a2.CaballosDeFuerza))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator != (AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
    }
}
