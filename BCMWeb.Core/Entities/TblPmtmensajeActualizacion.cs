using System;

namespace BCMWeb.Core.Entities
{
    public partial class TblPmtmensajeActualizacion
    {
        public long IdEmpresa { get; set; }
        public long IdMensaje { get; set; }
        public long IdModulo { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public DateTime FechaUltimoEnvio { get; set; }

        public virtual TblModulo Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
    }
}
