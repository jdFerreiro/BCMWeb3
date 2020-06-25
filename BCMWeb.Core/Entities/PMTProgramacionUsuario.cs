using System;

namespace BCMWeb.Core.Entities
{
    public class PMTProgramacionUsuario
    {
        public long IdPMTProgramacion { get; set; }
        public long IdUsuario { get; set; }
        public Int16 IdTipoNotificacion { get; set; }
        public DateTime FechaUltimaNotificacion { get; set; }
    }
}
