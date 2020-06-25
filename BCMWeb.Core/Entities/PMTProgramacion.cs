using System;

namespace BCMWeb.Core.Entities
{
    public class PMTProgramacion
    {
        public long IdPMTProgramacion { get; set; }
        public long IdEmpresa { get; set; }
        public long IdModulo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public long IdEstado { get; set; }
        public bool Negocios { get; set; }
        public Int16 IdTipoActualizacion { get; set; }
        public long IdTipoFrecuencia { get; set; }
    }
}
