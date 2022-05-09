using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;
        public DirectorTecnico(string nombre):base(0,nombre)
        {

        }

        public DirectorTecnico(string nombre, DateTime fechaNacimiento):this(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.MostrarDatos());
            sb.AppendLine("Fecha de nacimiento: " + this.fechaNacimiento.ToString());

            return sb.ToString();
        }
        public static bool operator == (DirectorTecnico dt1, DirectorTecnico dt2)
        {
            if (dt1 is not null && dt2 is not null)
            {
                if ((((Persona)dt1).Nombre == ((Persona)dt2).Nombre)&&(dt1.fechaNacimiento == dt2.fechaNacimiento))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator != (DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
