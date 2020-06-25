using System;

namespace BCMWeb.Core.Entities
{
    public class PPEFrecuencia
    {
        public long IdEmpresa { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }
        public long IdPPEFrecuencia { get; set; }
        public string TipoPrueba { get; set; }
        public string Participantes { get; set; }
        public string Proposito { get; set; }
        public long IdTipoFrecuencia { get; set; }
    }
}
