using System;

namespace BCMWeb.Core.Entities
{
    public partial class TblDocumentoAnexo
    {
        public long IdEmpresa { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }
        public long IdAnexo { get; set; }
        public long? ParentId { get; set; }
        public string Nombre { get; set; }
        public bool? IsFolder { get; set; }
        public byte[] Data { get; set; }
        public DateTime? LastWriteTime { get; set; }

        public virtual TblDocumento Id { get; set; }
    }
}
