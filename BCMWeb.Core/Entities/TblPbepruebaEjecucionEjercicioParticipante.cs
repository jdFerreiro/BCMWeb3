namespace BCMWeb.Core.Entities
{
    public partial class TblPbepruebaEjecucionEjercicioParticipante
    {
        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public long IdEjercicio { get; set; }
        public long IdParticipante { get; set; }
        public bool Responsable { get; set; }

        public virtual TblPbepruebaEjecucionEjercicio Id { get; set; }
        public virtual TblPbepruebaEjecucionParticipante IdNavigation { get; set; }
    }
}
