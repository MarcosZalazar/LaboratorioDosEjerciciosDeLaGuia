using System;
using System.Collections.Generic;

namespace LogicaNegocio
{
    public class Libro
    {
        //Ejercicio I02 - ¿Consultaste el índice? (Unidad 7 Encapsulamiento)

        private List <string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }

        public string this [int i]
        {
            get
            {
                if (i>=0 && i<=this.paginas.Count)
                {
                    return paginas[i];
                }
                return "";
            }
            set
            {
                if (i >= 0 && i <= this.paginas.Count)
                {
                    this.paginas.Insert(i,value);
                }
                else 
                { 
                    this.paginas.Add(value);
                }
            }
        }
    }
}
