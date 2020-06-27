using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblTipoDireccion
    {
        public TblTipoDireccion()
        {
            TblCulturaTipoDireccion = new HashSet<TblCulturaTipoDireccion>();
            TblPersonaDireccion = new HashSet<TblPersonaDireccion>();
        }

        public long IdTipoDireccion { get; set; }

        public virtual ICollection<TblCulturaTipoDireccion> TblCulturaTipoDireccion { get; set; }
        public virtual ICollection<TblPersonaDireccion> TblPersonaDireccion { get; set; }
    }
}
