using System;

namespace BCMWeb.Core.Entities
{
    public partial class TblPlanTrabajoAuditoria
    {
        public long IdEmpresa { get; set; }
        public long IdAccion { get; set; }
        public long IdActividad { get; set; }
        public long IdCambioEstado { get; set; }
        public DateTime FechaCambioEstado { get; set; }
        public short Estado { get; set; }
        public long IdUsuarioCambioEstado { get; set; }

        public virtual TblPlanTrabajoEstatus EstadoNavigation { get; set; }
        public virtual TblPlanTrabajoAccion Id { get; set; }
        public virtual TblPlanTrabajo IdNavigation { get; set; }
        public virtual User IdUsuarioCambioEstadoNavigation { get; set; }
    }
}
