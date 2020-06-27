using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblPmtprogramacionTipoNotificacion
    {
        public TblPmtprogramacionTipoNotificacion()
        {
            TblCulturaPmtprogramacionTipoNotificacion = new HashSet<TblCulturaPmtprogramacionTipoNotificacion>();
            TblPmtprogramacionUsuario = new HashSet<TblPmtprogramacionUsuario>();
        }

        public short IdTipoNotificacion { get; set; }

        public virtual ICollection<TblCulturaPmtprogramacionTipoNotificacion> TblCulturaPmtprogramacionTipoNotificacion { get; set; }
        public virtual ICollection<TblPmtprogramacionUsuario> TblPmtprogramacionUsuario { get; set; }
    }
}
