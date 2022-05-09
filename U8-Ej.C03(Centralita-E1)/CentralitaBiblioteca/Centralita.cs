using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaBiblioteca
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas=new List<Llamada>();
        }
        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;

            }
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia=0.0f;

            foreach (Llamada llamada in listaDeLlamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (llamada is Local)
                        {
                            ganancia = ganancia + ((Local)llamada).Costo;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            ganancia = ganancia + ((Provincial)llamada).Costo;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (llamada is Local)
                        {
                            ganancia = ganancia + ((Local)llamada).Costo;
                        }
                        else  
                        {
                            if (llamada is Provincial) 
                            {
                                ganancia = ganancia + ((Provincial)llamada).Costo;
                            }
                        }
                        break;
                }
            }
            return ganancia;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razón social:{this.razonSocial}{Environment.NewLine}");
            sb.AppendLine($"Ganancias total:{this.GananciasPorTotal}");
            sb.AppendLine($"Ganancias por llamadas locales:{this.GananciasPorLocal}");
            sb.AppendLine($"Ganancias por llamadas provinciales:{this.GananciasPorProvincial}{Environment.NewLine}");

            foreach (Llamada llamada in this.Llamadas)
            {
                sb.AppendLine($"{llamada.Mostrar()}");
            }
            sb.AppendLine("--------------------------------------------------------------------------------");
            return sb.ToString();
        }
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
    }
}
