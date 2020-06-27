using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblEstadoProceso
    {
        public TblEstadoProceso()
        {
            TblBiaproceso = new HashSet<TblBiaproceso>();
            TblCulturaEstadoProceso = new HashSet<TblCulturaEstadoProceso>();
        }

        public long IdEstadoProceso { get; set; }

        public virtual ICollection<TblBiaproceso> TblBiaproceso { get; set; }
        public virtual ICollection<TblCulturaEstadoProceso> TblCulturaEstadoProceso { get; set; }
    }
}
