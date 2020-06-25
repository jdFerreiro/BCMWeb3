using System;

namespace BCMWeb.Core.Entities
{
    public class BCPDocumento
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBCP { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdProceso { get; set; }
        public long IdUnidadOrganizativa { get; set; }
        public string Proceso { get; set; }
        public string SubProceso { get; set; }
        public string Responsable { get; set; }
    }
}
