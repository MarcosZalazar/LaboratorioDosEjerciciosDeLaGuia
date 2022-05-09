using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrescrito
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad
        {
            get;
        }

        public abstract string MiMetodo();

        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(object obj)
        {
            //return obj.GetType() == this.GetType();Se puede usar porque son tipos, no instancias
            //return obj.GetType() == typeof(Sobrescrito);
            Sobrescrito aux = obj as Sobrescrito;
            if (aux is not null)
            {
                return true;
            }
            return false;
            //return obj is Sobrescrito;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }


    }
}
