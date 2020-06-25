using System;

namespace BCMWeb.Core.Entities
{
    public class BIAProveedor
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdProceso { get; set; }
        public long IdProveedor { get; set; }
        public string Organizacion { get; set; }
        public string Servicio { get; set; }
        public string Contacto { get; set; }
    }
}
