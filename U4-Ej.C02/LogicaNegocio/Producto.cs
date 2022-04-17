using System;

namespace LogicaNegocio
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }
        public string GetMarca() 
        { 
            return this.marca;
        
        }

        public float GetPrecio()
        {
            return this.precio;

        }

        public static string MostrarProducto(Producto p) 
        {
            return $"Código de Barra:{(string)p} Marca:{p.GetMarca()} Precio:{p.GetPrecio()}";
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator == (Producto p, string marca)
        {
            return p.marca == marca;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            if ((p1 is not null)&& (p2 is not null))
            {
                return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
            }
            return false;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }
}
