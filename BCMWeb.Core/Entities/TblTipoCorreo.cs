using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblTipoCorreo
    {
        public TblTipoCorreo()
        {
            TblCulturaTipoCorreo = new HashSet<TblCulturaTipoCorreo>();
            TblPersonaCorreo = new HashSet<TblPersonaCorreo>();
        }

        public long IdTipoCorreo { get; set; }

        public virtual ICollection<TblCulturaTipoCorreo> TblCulturaTipoCorreo { get; set; }
        public virtual ICollection<TblPersonaCorreo> TblPersonaCorreo { get; set; }
    }
}
