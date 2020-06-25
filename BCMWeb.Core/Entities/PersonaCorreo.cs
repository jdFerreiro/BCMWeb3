using System;

namespace BCMWeb.Core.Entities
{
    public class PersonaCorreo
    {
        public long IdEmpresa { get; set; }
        public long IdPersona { get; set; }
        public long IdPersonaCorreo { get; set; }
        public string Correo { get; set; }
        public long IdTipoCorreo { get; set; }
    }
}
