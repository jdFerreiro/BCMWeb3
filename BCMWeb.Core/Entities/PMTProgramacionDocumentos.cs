using System;

namespace BCMWeb.Core.Entities
{
    public class PMTProgramacionDocumentos
    {
        public long IdPMTProgramacion { get; set; }
        public long IdEmpresa { get; set; }
        public long IdModulo { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }
    }
}
