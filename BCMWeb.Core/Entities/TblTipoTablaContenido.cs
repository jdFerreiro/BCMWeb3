using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblTipoTablaContenido
    {
        public TblTipoTablaContenido()
        {
            TblCulturaTipoTablaContenido = new HashSet<TblCulturaTipoTablaContenido>();
        }

        public int IdTipoTablaContenido { get; set; }

        public virtual ICollection<TblCulturaTipoTablaContenido> TblCulturaTipoTablaContenido { get; set; }
    }
}
