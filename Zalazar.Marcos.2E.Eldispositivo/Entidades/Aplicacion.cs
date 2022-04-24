using System;
using System.Text;
using System.Collections.Generic;

namespace Entidades
{

    public abstract class Aplicacion
    {
        protected string nombre;
        protected SistemaOperativo sistemaOperativo;
        protected int tamanioMb;

        protected Aplicacion(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.sistemaOperativo = sistemaOperativo;
            this.tamanioMb = tamanioMb;
        }

        public SistemaOperativo SistemaOperativo
        {
            get
            {
                return sistemaOperativo;
            }
        }

        protected abstract int Tamanio
        {
            get;
        }

        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre:{ToString()}");
            sb.AppendLine($"Sistema operativo:{this.SistemaOperativo}");
            sb.AppendLine($"Tamaño ocupado: {this.Tamanio}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public static implicit operator Aplicacion(List<Aplicacion>listaApp) 
        {
            Aplicacion aplicacionMasPesada = null;

            foreach (Aplicacion aplicacion in listaApp)
            {
                if (aplicacionMasPesada is null || aplicacion.Tamanio>aplicacionMasPesada.Tamanio)
                {
                    aplicacionMasPesada = aplicacion;

                }
            }
            return aplicacionMasPesada;
        }

        public static bool operator == (List<Aplicacion> listaApp, Aplicacion app)
        {
            bool estaEnLaLista = false;

            foreach (Aplicacion aplicacion in listaApp)
            {
                if (aplicacion.nombre== app.nombre) 
                {
                    estaEnLaLista = true;
                    break;
                }
            }   
            return estaEnLaLista;
        }
        public static bool operator != (List<Aplicacion> listaApp, Aplicacion app)
        {
            return !(listaApp == app);
        }
        public static bool operator + (List<Aplicacion> listaApp, Aplicacion app)
        {
            if (listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }
    }
}

