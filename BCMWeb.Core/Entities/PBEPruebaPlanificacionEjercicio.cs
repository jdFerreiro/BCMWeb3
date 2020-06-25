using System;

namespace BCMWeb.Core.Entities
{
    public class PBEPruebaPlanificacionEjercicio
    {
        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public long IdEjercicio { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public int DuracionHoras { get; set; }
        public int DuracionMinutos { get; set; }
    }
}
