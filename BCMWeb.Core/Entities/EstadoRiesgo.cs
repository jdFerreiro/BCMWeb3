using System;

namespace BCMWeb.Core.Entities
{
    public class EstadoRiesgo
    {
        public long IdEmpresa { get; set; }
        public Int16 IdEstadoRiesgo { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }
    }
}
