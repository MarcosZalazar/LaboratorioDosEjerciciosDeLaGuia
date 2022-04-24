using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrescrito
{
    public class Sobrescrito
    {
        public override string ToString()
        {
            return "¡Este es mi método ToString sobrescrito!";
        }
        public override bool Equals(Sobrescrito a, Sobrescrito b)
        {
            if (a is not null && b is not null)
            {
                return a==b;
            }
        }
    }
}
