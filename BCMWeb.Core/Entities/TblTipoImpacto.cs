using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblTipoImpacto
    {
        public TblTipoImpacto()
        {
            TblCulturaTipoImpacto = new HashSet<TblCulturaTipoImpacto>();
        }

        public int IdTipoImpacto { get; set; }

        public virtual ICollection<TblCulturaTipoImpacto> TblCulturaTipoImpacto { get; set; }
    }
}
