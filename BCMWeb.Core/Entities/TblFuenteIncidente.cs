using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblFuenteIncidente
    {
        public TblFuenteIncidente()
        {
            TblCultureFuenteIncidente = new HashSet<TblCultureFuenteIncidente>();
            TblIncidentes = new HashSet<TblIncidentes>();
        }

        public int IdFuenteIncidente { get; set; }

        public virtual ICollection<TblCultureFuenteIncidente> TblCultureFuenteIncidente { get; set; }
        public virtual ICollection<TblIncidentes> TblIncidentes { get; set; }
    }
}
