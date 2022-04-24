using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AppMusical : Aplicacion
    {

        private List<string> listaCanciones;

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial):this(nombre, sistemaOperativo, tamanioInicial,null)
        {
            
        }

        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, int tamanioInicial, List<string> listaCanciones):base(nombre, sistemaOperativo, tamanioInicial)
        {
            if (listaCanciones is not null)
            {
                this.listaCanciones = listaCanciones;
            }
            else 
            {
                this.listaCanciones = new List<string>();
            }
        }

        protected override int Tamanio
        {
            get
            {
                return tamanioMb + (2 * this.listaCanciones.Count);
            }
        }
        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ObtenerInformacionApp());
            sb.AppendLine("Lista de canciones: ");

            foreach (string cancion in listaCanciones)
            {
                if (cancion is not null) 
                {
                    sb.Append(cancion);
                    sb.Append(" ");
                }
            }
            return sb.ToString();
        }
    }
}
