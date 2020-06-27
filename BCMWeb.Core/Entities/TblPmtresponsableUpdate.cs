using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblPmtresponsableUpdate
    {
        public TblPmtresponsableUpdate()
        {
            TblPmtresponsableUpdateCorreo = new HashSet<TblPmtresponsableUpdateCorreo>();
        }

        public long IdEmpresa { get; set; }
        public long IdModulo { get; set; }
        public long IdMensaje { get; set; }
        public long? IdDocumento { get; set; }
        public short? IdTipoNotificacion { get; set; }

        public virtual TblModulo Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual ICollection<TblPmtresponsableUpdateCorreo> TblPmtresponsableUpdateCorreo { get; set; }
    }
}
