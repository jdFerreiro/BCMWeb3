using System;

namespace BCMWeb.Core.Entities
{
    public class PlanTrabajo
    {
        public long IdEmpresa { get; set; }
        public long IdAccion { get; set; }
        public long IdActividad { get; set; }
        public string Recomendacion { get; set; }
        public string Responsable { get; set; }
        public DateTime FechaPropuestaEjecucion { get; set; }
        public Int16 Ejecutada { get; set; }
        public long IdActividadPadre { get; set; }
    }
}
