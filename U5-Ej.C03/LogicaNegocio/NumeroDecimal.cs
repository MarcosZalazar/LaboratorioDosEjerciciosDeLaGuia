using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double Numero
        {
            get 
            {
                return this.numero;
            }
        }

        public string DecimalBinario(double numero)
        {
            string valorBinario = string.Empty;
            int resultDiv = (int)numero;
            int restoDiv;

            if (resultDiv>=0)
            {
                do 
                {
                    restoDiv = resultDiv % 2;
                    resultDiv /= 2;
                    valorBinario= restoDiv.ToString()+ valorBinario;
                } while (resultDiv > 0);
            }
            return valorBinario;
        }

        public static explicit operator NumeroDecimal(double numero)
        { 
            return new NumeroDecimal(numero);
        }

        public static explicit operator NumeroBinario(NumeroDecimal numeroDecimal)
        {
            return (NumeroBinario)numeroDecimal.DecimalBinario(numeroDecimal.Numero);
        }

        public static bool operator ==(NumeroDecimal numeroDecimal, NumeroBinario numBinario)
        {
            return numeroDecimal.Numero == ((NumeroDecimal)numBinario).Numero;
        }

        public static bool operator !=(NumeroDecimal numeroDecimal, NumeroBinario numBinario)
        {
            return !(numeroDecimal == numBinario);
        }


        public static double operator + (NumeroDecimal numeroDecimal, NumeroBinario numBinario)
        {
            return numeroDecimal.Numero + ((NumeroDecimal)numBinario).Numero;
        }

        public static double operator - (NumeroDecimal numeroDecimal, NumeroBinario numBinario)
        {
            return numeroDecimal.Numero - ((NumeroDecimal)numBinario).Numero;
        }
    }
}
