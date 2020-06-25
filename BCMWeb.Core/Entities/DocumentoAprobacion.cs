using System;

namespace BCMWeb.Core.Entities
{
    public class DocumentoAprobacion
    {
        public long IdEmpresa { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }
        public long IdAprobacion { get; set; }
        public DateTime Fecha { get; set; }
        public long IdPersona { get; set; }
        public bool Procesado { get; set; }
        public bool Aprobado { get; set; }
    }
}
