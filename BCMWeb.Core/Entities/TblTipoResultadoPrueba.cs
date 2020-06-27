using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblTipoResultadoPrueba
    {
        public TblTipoResultadoPrueba()
        {
            TblCulturaTipoResultadoPrueba = new HashSet<TblCulturaTipoResultadoPrueba>();
        }

        public int IdTipoResultadoPrueba { get; set; }

        public virtual ICollection<TblCulturaTipoResultadoPrueba> TblCulturaTipoResultadoPrueba { get; set; }
    }
}
