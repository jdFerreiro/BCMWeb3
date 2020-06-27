using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblPlanTrabajo
    {
        public TblPlanTrabajo()
        {
            TblPlanTrabajoAuditoria = new HashSet<TblPlanTrabajoAuditoria>();
        }

        public long IdEmpresa { get; set; }
        public long IdAccion { get; set; }
        public long IdActividad { get; set; }
        public string Recomendacion { get; set; }
        public string Responsable { get; set; }
        public DateTime FechaPropuestaEjecucion { get; set; }
        public short Ejecutada { get; set; }
        public long? IdActividadPadre { get; set; }

        public virtual TblPlanTrabajoEstatus EjecutadaNavigation { get; set; }
        public virtual TblPlanTrabajoAccion Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual ICollection<TblPlanTrabajoAuditoria> TblPlanTrabajoAuditoria { get; set; }
    }
}
