using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblNivelImpacto
    {
        public TblNivelImpacto()
        {
            TblCulturaNivelImpacto = new HashSet<TblCulturaNivelImpacto>();
        }

        public int IdNivelImpacto { get; set; }

        public virtual ICollection<TblCulturaNivelImpacto> TblCulturaNivelImpacto { get; set; }
    }
}
