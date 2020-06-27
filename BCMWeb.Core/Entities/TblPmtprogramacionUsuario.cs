using System;

namespace BCMWeb.Core.Entities
{
    public partial class TblPmtprogramacionUsuario
    {
        public long IdPmtprogramacion { get; set; }
        public long IdUsuario { get; set; }
        public short? IdTipoNotificacion { get; set; }
        public DateTime? FechaUltimaNotificacion { get; set; }

        public virtual TblPmtprogramacion IdPmtprogramacionNavigation { get; set; }
        public virtual TblPmtprogramacionTipoNotificacion IdTipoNotificacionNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
