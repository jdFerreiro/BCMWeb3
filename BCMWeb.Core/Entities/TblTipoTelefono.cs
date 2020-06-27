using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblTipoTelefono
    {
        public TblTipoTelefono()
        {
            TblCulturaTipoTelefono = new HashSet<TblCulturaTipoTelefono>();
            TblPersonaTelefono = new HashSet<TblPersonaTelefono>();
        }

        public long IdTipoTelefono { get; set; }

        public virtual ICollection<TblCulturaTipoTelefono> TblCulturaTipoTelefono { get; set; }
        public virtual ICollection<TblPersonaTelefono> TblPersonaTelefono { get; set; }
    }
}
