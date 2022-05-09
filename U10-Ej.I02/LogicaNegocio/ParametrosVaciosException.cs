using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ParametrosVaciosException : Exception
    {
        public ParametrosVaciosException(string message) : this(message, null)
        {

        }

        public ParametrosVaciosException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
