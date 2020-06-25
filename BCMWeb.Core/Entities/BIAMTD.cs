using System;

namespace BCMWeb.Core.Entities
{
    public class BIAMTD
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdProceso { get; set; }
        public long IdMTD { get; set; }
        public string Observacion { get; set; }
        public long IdTipoFrecuencia { get; set; }
        public long IdEscala { get; set; }
    }
}