using System;

namespace BCMWeb.Core.Entities
{
    public class UsuarioUnidadOrganizativa
    {
        public long IdEmpresa { get; set; }
        public long IdUnidadOrganizativa { get; set; }
        public long IdUsuario { get; set; }
        public long IdNivelUsuario { get; set; }
    }
}
