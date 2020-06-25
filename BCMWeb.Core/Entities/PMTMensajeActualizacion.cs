using System;

namespace BCMWeb.Core.Entities
{
    public class PMTMensajeActualizacion
    {
        public long IdEmpresa { get; set; }
        public long IdMensaje { get; set; }
        public long IdModulo { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public DateTime FechaUltimoEnvio { get; set; }
    }
}
