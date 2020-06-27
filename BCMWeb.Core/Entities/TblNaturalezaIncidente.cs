using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblNaturalezaIncidente
    {
        public TblNaturalezaIncidente()
        {
            TblCultureNaturalezaIncidente = new HashSet<TblCultureNaturalezaIncidente>();
            TblIncidentes = new HashSet<TblIncidentes>();
        }

        public int IdNaturalezaIncidente { get; set; }

        public virtual ICollection<TblCultureNaturalezaIncidente> TblCultureNaturalezaIncidente { get; set; }
        public virtual ICollection<TblIncidentes> TblIncidentes { get; set; }
    }
}
