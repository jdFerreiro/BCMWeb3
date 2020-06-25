using BCMWeb.Core.Enums;
using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class Usuario
    {
        public long IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string CodigoUsuario { get; set; }
        public string ClaveUsuario { get; set; }
        public UsuarioEstado EstadoUsuario { get; set; }
        public DateTime FechaEstado { get; set; }
        public DateTime FechaUltimaConexion { get; set; }
        public bool PrimeraVez { get; set; }
        public string Email { get; set; }

        public IEnumerable<Empresa> Empresas { get; set; }
    }
}
