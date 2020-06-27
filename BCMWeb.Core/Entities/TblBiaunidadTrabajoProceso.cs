using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblBiaunidadTrabajoProceso
    {
        public TblBiaunidadTrabajoProceso()
        {
            TblBiaunidadTrabajoPersonas = new HashSet<TblBiaunidadTrabajoPersonas>();
        }

        public long IdEmpresa { get; set; }
        public long IdUnidadTrabajo { get; set; }
        public long IdUnidadTrabajoProceso { get; set; }
        public string Nombre { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }

        public virtual TblBiaunidadTrabajo Id { get; set; }
        public virtual TblBiaproceso IdNavigation { get; set; }
        public virtual ICollection<TblBiaunidadTrabajoPersonas> TblBiaunidadTrabajoPersonas { get; set; }
    }
}
