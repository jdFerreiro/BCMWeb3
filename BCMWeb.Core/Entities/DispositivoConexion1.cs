using System;

namespace BCMWeb.Core.Entities
{
    public class DispositivoConexion1
    {
        public long IdDispositivo { get; set; }
        public long IdUsuario { get; set; }
        public DateTime FechaConexion { get; set; }
        public long IdEmpresa { get; set; }
        public long IdSubModulo { get; set; }
        public string DirecciónIP { get; set; }
    }
}
