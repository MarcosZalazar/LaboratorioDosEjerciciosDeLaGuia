using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Rectangulo:Figura
    {
        private double longitudBase;
        private double longitudAltura;

        public Rectangulo(double longitudBase, double longitudAltura)
        {
            this.longitudBase = longitudBase;
            this.longitudAltura = longitudAltura;
        }

        public override string Dibujar()
        {
            return "Dibujando rectángulo";
        }
        public override double CalcularSuperficie()
        { 
             return longitudBase * longitudAltura;
        }
        public override double CalcularPerimetro()
        {
            return (longitudBase+longitudAltura)*2;
        }
    }
}
