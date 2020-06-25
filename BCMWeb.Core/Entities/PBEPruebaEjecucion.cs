using System;

namespace BCMWeb.Core.Entities
{
    public class PBEPruebaEjecucion
    {
        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Lugar { get; set; }
    }
}
