using System;
using LogicaNegocio;

namespace LogicaNegocio
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular,decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        { 
            return this.titular;
        }
        public decimal GetCantidad()
        {
            return this.cantidad;
        }
        public string Mostrar()
        {
            string mensaje;

            mensaje = $"El titular de la cuenta es:{this.titular} y la cantidad es:{this.cantidad}";

            return mensaje;
        }

        public void Ingresar(decimal dineroAAcreditar)
        {
            if (dineroAAcreditar > 0)
            {
                this.cantidad = this.cantidad+dineroAAcreditar;
            
            }
        }
        public void Retirar(decimal dineroADebitar)
        {
            this.cantidad = this.cantidad - dineroADebitar;
        }
    }
}
