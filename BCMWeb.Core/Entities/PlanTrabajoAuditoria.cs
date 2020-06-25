using System;

namespace BCMWeb.Core.Entities
{
    public class PlanTrabajoAuditoria
    {
        public long IdEmpresa { get; set; }
        public long IdAccion { get; set; }
        public long IdActividad { get; set; }
        public long IdCambioEstado { get; set; }
        public DateTime FechaCambioEstado { get; set; }
        public Int16 Estado { get; set; }
        public long IdUsuarioCambioEstado { get; set; }
    }
}
