namespace BCMWeb.Core.Entities
{
    public class PBEPruebaEjecucionEjercicioParticipante
    {
        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public long IdEjercicio { get; set; }
        public long IdParticipante { get; set; }
        public bool Responsable { get; set; }
    }
}
