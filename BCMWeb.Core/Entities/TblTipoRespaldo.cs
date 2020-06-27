using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblTipoRespaldo
    {
        public TblTipoRespaldo()
        {
            TblCulturaTipoRespaldo = new HashSet<TblCulturaTipoRespaldo>();
        }

        public int IdTipoRespaldo { get; set; }

        public virtual ICollection<TblCulturaTipoRespaldo> TblCulturaTipoRespaldo { get; set; }
    }
}
