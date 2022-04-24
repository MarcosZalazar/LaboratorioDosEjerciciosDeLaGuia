using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Dispositivo
    {
        private static List<Aplicacion> appInstaladas;
        private static SistemaOperativo sistemaOperativo;

        static Dispositivo( )
        {
            appInstaladas=new List<Aplicacion>();
            sistemaOperativo = SistemaOperativo.ANDROID;
        }

        public static bool InstalarApp(Aplicacion app)
        {
            if (app.SistemaOperativo == sistemaOperativo)
            {
                return appInstaladas + app;
            }

            return false;
        }
        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sistema operativo: {sistemaOperativo}");

            foreach (Aplicacion aplicacion in appInstaladas)
            {  
                if (aplicacion is not null)
                {
                    sb.Append(aplicacion.ObtenerInformacionApp());
                    sb.Append(",");
                }
            }
            return sb.ToString();

        }
    }
}
