using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblMes
    {
        public TblMes()
        {
            TblBiagranImpacto = new HashSet<TblBiagranImpacto>();
            TblCulturaMes = new HashSet<TblCulturaMes>();
        }

        public int IdMes { get; set; }

        public virtual ICollection<TblBiagranImpacto> TblBiagranImpacto { get; set; }
        public virtual ICollection<TblCulturaMes> TblCulturaMes { get; set; }
    }
}
