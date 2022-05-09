using System;

namespace LogicaNegocio
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string Numero
        {
            get 
            {
                return this.numero;
            }   
        }

        public double BinarioDecimal (string valorRecibido)
        {
            double resultado = 0;
            int cantidadCaracteres = valorRecibido.Length;

            foreach (char caracter in valorRecibido)
            {
                cantidadCaracteres--;
                if(caracter == '1')
                {
                    resultado += (int)Math.Pow(2,cantidadCaracteres);
    
                } 
            }
            return resultado;
        }


        public static explicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }


        public static explicit operator NumeroDecimal(NumeroBinario numeroBinario)
        {
            return (NumeroDecimal)numeroBinario.BinarioDecimal(numeroBinario.Numero) ;
        }

        public static bool operator ==(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroBinario.Numero == ((NumeroBinario)numeroDecimal).Numero;
        }

        public static bool operator !=(NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return !(numeroBinario == numeroDecimal);
        }

        public static string operator + (NumeroBinario numeroBinario, NumeroDecimal numeroDecimal) 
        {
            return numeroDecimal.DecimalBinario(((NumeroDecimal)numeroBinario).Numero + numeroDecimal.Numero);
        }

        public static string operator - (NumeroBinario numeroBinario, NumeroDecimal numeroDecimal)
        {
            return numeroDecimal.DecimalBinario(((NumeroDecimal)numeroBinario).Numero - numeroDecimal.Numero);
        }
    }
}
