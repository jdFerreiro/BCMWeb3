using System;

namespace BCMWeb.Core.Entities
{
    public class BIADocumentacion
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdProceso { get; set; }
        public long IdDocumento { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
    }
}
