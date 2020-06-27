using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblTipoIncidente
    {
        public TblTipoIncidente()
        {
            TblCultureTipoIncidente = new HashSet<TblCultureTipoIncidente>();
            TblIncidentes = new HashSet<TblIncidentes>();
        }

        public int IdTipoIncidente { get; set; }

        public virtual ICollection<TblCultureTipoIncidente> TblCultureTipoIncidente { get; set; }
        public virtual ICollection<TblIncidentes> TblIncidentes { get; set; }
    }
}
