using System;

namespace BCMWeb.Core.Entities
{
    public partial class TblPmtresponsableUpdateCorreo
    {
        public long IdEmpresa { get; set; }
        public long IdModulo { get; set; }
        public long IdMensaje { get; set; }
        public long IdUsuario { get; set; }
        public DateTime? FechaRegistro { get; set; }

        public virtual TblPmtresponsableUpdate Id { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
