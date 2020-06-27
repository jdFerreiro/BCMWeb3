using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblPlanTrabajoEstatus
    {
        public TblPlanTrabajoEstatus()
        {
            TblCulturaPlanTrabajoEstatus = new HashSet<TblCulturaPlanTrabajoEstatus>();
            TblIniciativas = new HashSet<TblIniciativas>();
            TblPlanTrabajo = new HashSet<TblPlanTrabajo>();
            TblPlanTrabajoAuditoria = new HashSet<TblPlanTrabajoAuditoria>();
        }

        public short IdEstatusActividad { get; set; }

        public virtual ICollection<TblCulturaPlanTrabajoEstatus> TblCulturaPlanTrabajoEstatus { get; set; }
        public virtual ICollection<TblIniciativas> TblIniciativas { get; set; }
        public virtual ICollection<TblPlanTrabajo> TblPlanTrabajo { get; set; }
        public virtual ICollection<TblPlanTrabajoAuditoria> TblPlanTrabajoAuditoria { get; set; }
    }
}
