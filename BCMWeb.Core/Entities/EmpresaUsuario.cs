using System;

namespace BCMWeb.Core.Entities
{
    public class EmpresaUsuario
    {
        public long IdEmpresa { get; set; }
        public long IdUsuario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public long IdNivelUsuario { get; set; }
    }
}
