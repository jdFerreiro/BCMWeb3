using System;

namespace BCMWeb.Core.Entities
{
    public class BIAInterdependencia
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdProceso { get; set; }
        public long IdInterdependencia { get; set; }
        public string Organizacion { get; set; }
        public string Servicio { get; set; }
        public string Contacto { get; set; }
    }
}
