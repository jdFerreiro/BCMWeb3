using System;

namespace BCMWeb.Core.Entities
{
    public class Dispositivo1
    {
        public long IdDispositivo { get; set; }
        public long IdUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string IMEI_Dispositivo { get; set; }
        public string NombreDispositivo { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Plataforma { get; set; }
        public string Version { get; set; }
        public string TipoDispositivo { get; set; }
        public string TokenDispositivo { get; set; }
    }
}
