using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        private Estante(int capacidad)
        {
           
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad,int ubicacionEstante):this(capacidad)
        {
            this.ubicacionEstante = ubicacionEstante;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder infoEstante = new StringBuilder();
            string mensaje;

            infoEstante.AppendLine($"Ubicación:{e.ubicacionEstante}\n");

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] is not null)
                {
                    infoEstante.AppendLine(Producto.MostrarProducto(e.productos[i]));
                }
            }
            mensaje =infoEstante.ToString();    

            return mensaje;
        }

        public static bool operator == (Estante e, Producto p)
        {
            bool estaEnElEstante = false;

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i]==p)
                {
                    estaEnElEstante= true;
                    break;
                }
            }
            return estaEnElEstante;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e==p);
        }
        public static bool operator + (Estante e, Producto p)
        {
            bool seAgregoElProducto=false;

            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        seAgregoElProducto = true;
                        break;
                    }
                }
            }
            return seAgregoElProducto;
        }
        public static Estante operator - (Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e==p)
                {
                    e.productos[i] = null;
                    break;
                }
            }
            return e;
        }
    }
}
