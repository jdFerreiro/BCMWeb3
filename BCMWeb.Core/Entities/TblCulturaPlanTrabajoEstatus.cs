namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaPlanTrabajoEstatus
    {
        public string Culture { get; set; }
        public short IdEstatusActividad { get; set; }
        public string Descripcion { get; set; }

        public virtual TblPlanTrabajoEstatus IdEstatusActividadNavigation { get; set; }
    }
}
