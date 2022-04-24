using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Publicacion
    {
        protected float importe;
        protected string nombre;
        protected int stock;

        public Publicacion(string nombre)
        {
            this.nombre = nombre;

        }
        public Publicacion(string nombre, int stock):this(nombre)
        {
            Stock = stock;
        }
        public Publicacion(string nombre, int stock, float importe):this(nombre,stock)
        {
            this.importe = importe;
        }

        protected abstract bool EsColor
        {
            get;
        }
        public virtual bool HayStock
        {
            get
            {
                if (this.stock>0 && this.importe>0)
                {
                    return true;
                }
                return false;
            }
        }
        public float Importe
        {
            get
            {
                return this.importe;
            }
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value>0) 
                {
                    this.stock = value;
                }
            }
        }

        public string ObtenerInformacion()
        {
            string esColor = EsColor ? "SI" : "NO";

            StringBuilder informacion = new StringBuilder();
            informacion.AppendFormat("Nombre: {0}{1}", nombre, Environment.NewLine);
            informacion.Append($"Stock: {Stock}{Environment.NewLine}");
            informacion.AppendLine($"Es color: {esColor}");
            informacion.AppendLine($"Valor: ${importe}");

            return informacion.ToString();
        }
        public override string ToString()
        {
            return this.nombre;
        }
    }
}
