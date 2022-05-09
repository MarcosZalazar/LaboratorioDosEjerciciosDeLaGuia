using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public sealed class Circulo:Figura
    {
        private float radio;

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public override string Dibujar()
        {
            return "Dibujando cículo";
        }
        public override double CalcularSuperficie()
        {
            return Math.PI* Math.Pow(radio, 2);
        }
        public override double CalcularPerimetro()
        {
            return Math.PI * radio * 2;
        }


    }
}
