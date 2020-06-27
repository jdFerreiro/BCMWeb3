using System;

namespace BCMWeb.Core.Entities
{
    public partial class TblAuditoriaProcesoCritico
    {
        public long IdProceso { get; set; }
        public long IdAuditoriaProcesoCritico { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool EstadoAnterior { get; set; }
        public bool EstadoActual { get; set; }
        public long IdEmpresa { get; set; }
        public long IdUsuario { get; set; }

        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
