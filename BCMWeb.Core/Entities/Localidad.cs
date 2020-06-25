using System;

namespace BCMWeb.Core.Entities
{
    public class Localidad
    {
        public long IdEmpresa { get; set; }
        public long IdLocalidad { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public long IdPais { get; set; }
        public long IdEstado { get; set; }
        public long IdCiudad { get; set; }
    }
}
