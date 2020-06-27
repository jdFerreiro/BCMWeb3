using System;

namespace BCMWeb.Core.Entities
{
    public partial class TblDocumentoCertificacion
    {
        public long IdEmpresa { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }
        public long IdCertificacion { get; set; }
        public DateTime? Fecha { get; set; }
        public long? IdPersona { get; set; }
        public bool Procesado { get; set; }
        public bool? Certificado { get; set; }

        public virtual TblPersona Id { get; set; }
        public virtual TblDocumento IdNavigation { get; set; }
    }
}
