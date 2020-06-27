using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblPbepruebaEstatus
    {
        public TblPbepruebaEstatus()
        {
            TblCulturaPbepruebaEstatus = new HashSet<TblCulturaPbepruebaEstatus>();
            TblPbepruebaEjecucionEjercicio = new HashSet<TblPbepruebaEjecucionEjercicio>();
        }

        public short IdEstatus { get; set; }

        public virtual ICollection<TblCulturaPbepruebaEstatus> TblCulturaPbepruebaEstatus { get; set; }
        public virtual ICollection<TblPbepruebaEjecucionEjercicio> TblPbepruebaEjecucionEjercicio { get; set; }
    }
}
