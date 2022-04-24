using System;
using System.Collections.Generic;

namespace Centralita
{
    public class Centralita
    {
        private List<Llamada>listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
    
        }
        public Centralita(List<Llamada> listaDeLlamadas, string razonSocial)
        {
            this.listaDeLlamadas = listaDeLlamadas;
            this.razonSocial = razonSocial;
        }
        public float GananciasPorLocal
        {
            get
            {
                return;
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return;
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return;
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamadas;
                
            }
        }
        private float CalcularGanancia(TipoLlamada tipo)
        {

        }
        public string Mostrar()
        {

        }
        public void OrdenarLlamadas()
        {

        }

    }

}
