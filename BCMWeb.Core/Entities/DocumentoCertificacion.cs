using System;

namespace BCMWeb.Core.Entities
{
    public class DocumentoCertificacion
    {
        public long IdEmpresa { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }
        public long IdCertificacion { get; set; }
        public DateTime Fecha { get; set; }
        public long IdPersona { get; set; }
        public bool Procesado { get; set; }
        public bool Certificado { get; set; }
    }
}
