using System;

namespace BCMWeb.Core.Entities
{
    public partial class TblDocumentoContenido
    {
        public long IdEmpresa { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }
        public long IdSubModulo { get; set; }
        public byte[] ContenidoBin { get; set; }
        public DateTime? FechaCreacion { get; set; }

        public virtual TblModulo Id { get; set; }
        public virtual TblDocumento IdNavigation { get; set; }
    }
}
