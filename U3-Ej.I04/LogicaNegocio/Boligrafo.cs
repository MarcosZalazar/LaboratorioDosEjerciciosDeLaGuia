using System;

namespace LogicaNegocio
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        { 
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            //TERMINAR;
        }
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }
        public void SetTinta(short tinta)
        {
            if (this.tinta>=0 && this.tinta<=cantidadTintaMaxima)
            {
                this.tinta += tinta;
            }
        }
    }
}
