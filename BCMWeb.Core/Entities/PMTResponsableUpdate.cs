using System;

namespace BCMWeb.Core.Entities
{
    public class PMTResponsableUpdate
    {
        public long IdEmpresa { get; set; }
        public long IdModulo { get; set; }
        public long IdMensaje { get; set; }
        public long IdDocumento { get; set; }
        public Int16 IdTipoNotificacion { get; set; }
    }
}