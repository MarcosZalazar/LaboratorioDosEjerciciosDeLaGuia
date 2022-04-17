using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float Area()
        { 
            return this.area;
        }
        public float Perimetro()
        {
            return this.perimetro;
        }
        public Punto GetVertice1()
        {
            return this.vertice1;
        }
        public Punto GetVertice2()
        {
            return this.vertice2;
        }
        public Punto GetVertice3()
        {
            return this.vertice3;
        }
        public Punto GetVertice4()
        {
            return this.vertice4;
        }

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1=vertice1;
            this.vertice3=vertice3;

            this.vertice2 = new Punto(vertice1.GetX(),vertice3.GetY());
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());

            float baseRectangulo = Math.Abs(vertice4.GetX()) - Math.Abs(vertice1.GetX());
            float alturaRectangulo = Math.Abs(vertice2.GetY()) - Math.Abs(vertice1.GetY());
           
            this.area= baseRectangulo * alturaRectangulo;
            this.perimetro = (baseRectangulo + alturaRectangulo) * 2;
        }
    }
}
