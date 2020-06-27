using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblPlanTrabajoAccion
    {
        public TblPlanTrabajoAccion()
        {
            TblPlanTrabajo = new HashSet<TblPlanTrabajo>();
            TblPlanTrabajoAuditoria = new HashSet<TblPlanTrabajoAuditoria>();
        }

        public long IdEmpresa { get; set; }
        public long IdPlanAccion { get; set; }
        public string Descripcion { get; set; }

        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual ICollection<TblPlanTrabajo> TblPlanTrabajo { get; set; }
        public virtual ICollection<TblPlanTrabajoAuditoria> TblPlanTrabajoAuditoria { get; set; }
    }
}
