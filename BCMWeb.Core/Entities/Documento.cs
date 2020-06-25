using System;

namespace BCMWeb.Core.Entities
{
    public class Documento
    {
        public long IdEmpresa { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }
        public long NroDocumento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaUltimaModificacion { get; set; }
        public long IdEstadoDocumento { get; set; }
        public DateTime FechaEstadoDocumento { get; set; }
        public bool Negocios { get; set; }
        public int NroVersion { get; set; }
        public int VersionOriginal { get; set; }
        public long IdPersonaResponsable { get; set; }
        public bool RequiereCertificacion { get; set; }
    }
}
