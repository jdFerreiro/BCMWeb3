using System;

namespace BCMWeb.Core.Entities
{
    public class Modulo_NivelUsuario
    {
        public long IdEmpresa { get; set; }
        public long IdNivelUsuario { get; set; }
        public long IdModulo { get; set; }
        public bool Actualizar { get; set; }
        public bool Eliminar { get; set; }
    }
}
