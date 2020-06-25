using System;

namespace BCMWeb.Core.Entities
{
    public class Dispositivo
    {
        public long IdDispositivo { get; set; }
        public DateTime fechaRegistro { get; set; }
        public string IdUnicoDispositivo { get; set; }
        public string nombre { get; set; }
        public string fabricante { get; set; }
        public string modelo { get; set; }
        public string plataforma { get; set; }
        public string version { get; set; }
        public string tipo { get; set; }
        public string token { get; set; }
    }
}
