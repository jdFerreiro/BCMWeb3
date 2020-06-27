using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblPmtprogramacionTipoActualizacion
    {
        public TblPmtprogramacionTipoActualizacion()
        {
            TblCulturaPmtprogramacionTipoActualizacion = new HashSet<TblCulturaPmtprogramacionTipoActualizacion>();
            TblPmtprogramacion = new HashSet<TblPmtprogramacion>();
        }

        public short IdTipoActualizacion { get; set; }

        public virtual ICollection<TblCulturaPmtprogramacionTipoActualizacion> TblCulturaPmtprogramacionTipoActualizacion { get; set; }
        public virtual ICollection<TblPmtprogramacion> TblPmtprogramacion { get; set; }
    }
}
