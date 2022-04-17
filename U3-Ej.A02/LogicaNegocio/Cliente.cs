using System;
using System.Text;

namespace LogicaNegocio
{
    public class Cliente
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private string telefono;
        private Mascota[] arrayMascotas=new Mascota[5];

        public Cliente(string domicilio, string nombre, string apellido, string telefono)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }

        public string GetDomicilio()
        {
            return this.domicilio;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetApellido()
        {
            return this.apellido;
        }
        public string GetTelefono()
        {
            return this.telefono;
        }
        
        public string GetMascotas()
        {
            StringBuilder mascotasAMostrar = new StringBuilder();

            for (int i = 0; i < arrayMascotas.Length; i++)
            {
                if (arrayMascotas[i] is not null)
                {
                    mascotasAMostrar.Append(arrayMascotas[i].GetInfoCompletaMascota());
                }
            }
            return mascotasAMostrar.ToString(); 
        }
        public string GetInfoCompletaCliente()
        {
            StringBuilder infoCompleta = new StringBuilder();
            string mensaje;

            infoCompleta.AppendFormat($"Domicilio:{GetDomicilio()} Nombre:{GetNombre()} Apellido:{GetApellido()} Teléfono:{GetTelefono()} Mascotas(ver debajo)\n");
            infoCompleta.AppendLine($"{ GetMascotas()}");
            mensaje = infoCompleta.ToString();

            return mensaje;
        }
        public void SetDomicilio(string domicilio)
        {
            this.domicilio= domicilio;
        }
        public void SetNombre(string nombre)
        {
            this.nombre= nombre;
        }
        public void SetApellido(string apellido)
        {
            this.apellido= apellido;
        }
        public void SetTelefono(string telefono)
        {
            this.telefono= telefono;
        }
        public void SetMascota(int indice, Mascota mascota)
        {
            this.arrayMascotas[indice] = mascota;
        }
        public void SetMascotas(Mascota[] mascota)
        {
            this.arrayMascotas = mascota;
        }
    }
}
