using System;

namespace BCMWeb.Core.Entities
{
    public class BIARespaldoSecundario
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdProceso { get; set; }
        public long IdRespaldo { get; set; }
        public string Ubicacion { get; set; }
    }
}
