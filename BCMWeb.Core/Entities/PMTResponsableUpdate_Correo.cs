using System;

namespace BCMWeb.Core.Entities
{
    public class PMTResponsableUpdate_Correo
    {
        public long IdEmpresa { get; set; }
        public long IdModulo { get; set; }
        public long IdMensaje { get; set; }
        public long IdUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
