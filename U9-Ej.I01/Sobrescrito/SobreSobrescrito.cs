using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrescrito
{
    internal class SobreSobrescrito: Sobrescrito
    {
        public SobreSobrescrito():base()//no es necesario el base porque el constructor de la clase base es público sin parametros
        {

        }
        public override string MiPropiedad
        {
            get
            {
                return base.miAtributo;
            }
        }

        public override string MiMetodo()
        {
            return this.MiPropiedad;
        }

    }
}
