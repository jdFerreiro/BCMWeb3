using System;

namespace BCMWeb.Core.Entities
{
    public class PBEPruebaEjecucionEjercicio
    {
        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public long IdEjercicio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public int DuracionHoras { get; set; }
        public int DuracionMinutos { get; set; }
        public short IdEstatus { get; set; }
        public long IdEjercicioPlanificacion { get; set; }
    }
}
