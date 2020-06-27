namespace BCMWeb.Core.Entities
{
    public partial class TblPbepruebaPlanificacionEjercicioParticipante
    {
        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public long IdEjercicio { get; set; }
        public long IdParticipante { get; set; }
        public bool Responsable { get; set; }

        public virtual TblPbepruebaPlanificacionEjercicio Id { get; set; }
        public virtual TblPbepruebaPlanificacionParticipante IdNavigation { get; set; }
    }
}
