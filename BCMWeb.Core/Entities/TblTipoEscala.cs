using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblTipoEscala
    {
        public TblTipoEscala()
        {
            TblEscala = new HashSet<TblEscala>();
        }

        public long IdEmpresa { get; set; }
        public long IdTipoEscala { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<TblEscala> TblEscala { get; set; }
    }
}
