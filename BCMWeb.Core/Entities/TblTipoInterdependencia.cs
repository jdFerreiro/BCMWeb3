using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblTipoInterdependencia
    {
        public TblTipoInterdependencia()
        {
            TblCulturaTipoInterdependencia = new HashSet<TblCulturaTipoInterdependencia>();
        }

        public int IdTipoInterdependencia { get; set; }

        public virtual ICollection<TblCulturaTipoInterdependencia> TblCulturaTipoInterdependencia { get; set; }
    }
}
