using System;

namespace BCMWeb.Core.Entities
{
    public class Criticidad
    {
        public DateTime FechaAplicacion { get; set; }
        public long IdEmpresa { get; set; }
        public long IdTipoEscala { get; set; }
        public string DescripcionEscala { get; set; }
    }
}
