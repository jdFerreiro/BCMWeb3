using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblBiaclienteProceso
    {
        public TblBiaclienteProceso()
        {
            TblBiaunidadTrabajoPersonas = new HashSet<TblBiaunidadTrabajoPersonas>();
        }

        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }
        public long IdClienteProceso { get; set; }
        public string Unidad { get; set; }
        public string Responsable { get; set; }
        public string Proceso { get; set; }
        public string Producto { get; set; }

        public virtual TblBiaproceso Id { get; set; }
        public virtual ICollection<TblBiaunidadTrabajoPersonas> TblBiaunidadTrabajoPersonas { get; set; }
    }
}
