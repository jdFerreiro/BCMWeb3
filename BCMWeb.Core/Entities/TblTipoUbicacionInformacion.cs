using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblTipoUbicacionInformacion
    {
        public TblTipoUbicacionInformacion()
        {
            TblCulturaTipoUbicacionInformacion = new HashSet<TblCulturaTipoUbicacionInformacion>();
        }

        public int IdTipoUbicacionInformacion { get; set; }

        public virtual ICollection<TblCulturaTipoUbicacionInformacion> TblCulturaTipoUbicacionInformacion { get; set; }
    }
}
