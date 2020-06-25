using System;

namespace BCMWeb.Core.Entities
{
    public class PBEPruebaPlanificacion
    {
        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public bool Negocios { get; set; }
        public string Prueba { get; set; }
        public string Propósito { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Lugar { get; set; }
        public Int16 IdEstatus { get; set; }
    }
}
