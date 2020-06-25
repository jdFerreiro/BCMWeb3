using System;

namespace BCMWeb.Core.Entities
{
    public class DispositivoConexion
    {
        public long IdEmpresa { get; set; }
        public long IdDispositivo { get; set; }
        public long IdUsuario { get; set; }
        public DateTime fechaConexion { get; set; }
        public string DireccionIP { get; set; }
    }
}
