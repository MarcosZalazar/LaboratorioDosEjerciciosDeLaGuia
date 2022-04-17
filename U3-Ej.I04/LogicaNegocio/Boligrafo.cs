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
            this.tinta = tinta;
            this.color = color;
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
            bool sePudoPintar;
            short nivelDeTinta;
            int i;

            sePudoPintar = false;
            dibujo = "";

            nivelDeTinta = GetTinta();

            if (nivelDeTinta != 0)
            {
                for (i = 1;i <= Math.Abs(gasto); i++)
                {
                    dibujo= dibujo + '*';
                    nivelDeTinta--;

                    if (nivelDeTinta==0)
                    {
                        break;
                    }
                }
                SetTinta (gasto);
                sePudoPintar = true;
            }
            
            return sePudoPintar;
        }
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }
        private void SetTinta(short tinta)
        {
            short nuevoNivelDeTinta;

            nuevoNivelDeTinta = (short) (GetTinta()+ tinta);

            if (nuevoNivelDeTinta > cantidadTintaMaxima)
            {
                this.tinta=cantidadTintaMaxima;
            }
            else 
            {
                if (nuevoNivelDeTinta < 0)
                {
                    this.tinta = 0;
                }
                else 
                {
                    this.tinta = nuevoNivelDeTinta;
                }
            }
        }
    }
}
