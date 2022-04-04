using System;

namespace LogicaNegocio
{
    public class Calculadora
    {
        public static decimal resultado;
        public static decimal Calcular(decimal primerOperando, decimal segundoOperando, char operacionMatemática)
        {
            switch (operacionMatemática)
            {
                case '+':
                    resultado = primerOperando + segundoOperando;
                    break;

                case '-':
                    resultado = primerOperando - segundoOperando;
                    break;

                case '*':
                    resultado = primerOperando * segundoOperando;
                    break;

                case '/':
                    if (Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }
                    else 
                    {
                        Console.WriteLine("No se puede realizar la división por cero");
                    }
                    break;

                default:
                    Console.WriteLine("Operación inválida. Ingrese + (suma), - (resta), * (multiplicación) o / (división)");
                    break;
            }
            return resultado;
        }
        private static bool Validar (decimal segundoOperando)
        {
            bool esDistintoACero;

            esDistintoACero = true;

            if (segundoOperando==0)
            {
                esDistintoACero = false;

            }
            return esDistintoACero;
        }
    }
}
