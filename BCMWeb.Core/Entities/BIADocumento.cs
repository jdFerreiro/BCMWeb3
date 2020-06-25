using System;

namespace BCMWeb.Core.Entities
{
    public class BIADocumento
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdDocumento { get; set; }
        public long IdUnidadOrganizativa { get; set; }
        public long IdCadenaServicio { get; set; }
        public long IdTipoDocumento { get; set; }
    }
}
