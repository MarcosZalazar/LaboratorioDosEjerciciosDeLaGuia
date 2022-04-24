using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vendedor
    {
        private string nombre;
        private List<Publicacion> ventas;

        private Vendedor( )
        {
            ventas=new List<Publicacion>();
        }
        public Vendedor(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static string ObtenerInformeDeVentas(Vendedor vendedor)
        {
            float gananciasVendedor=0f;
            StringBuilder sb=new StringBuilder();

            sb.AppendLine($"NOMBRE:{vendedor.nombre.ToUpper()}");
            sb.AppendLine("--------------------------------------");

            foreach (Publicacion publicacionVendida in vendedor.ventas)
            {
                sb.AppendLine($"PUBLICACION:{publicacionVendida.ObtenerInformacion()}");
                sb.AppendLine("--------------------------------------");
                gananciasVendedor = gananciasVendedor + publicacionVendida.Importe;
            }
            sb.AppendLine($"Ganancia Total:{gananciasVendedor}");

            return sb.ToString();
        }
        public static bool operator + (Vendedor vendedor, Publicacion publicacion)
        {
            if (publicacion.Stock >0)
            { 
                vendedor.ventas.Add(publicacion);
                publicacion.Stock--;
                return true;
            }
            return false;
        }
    }
}
