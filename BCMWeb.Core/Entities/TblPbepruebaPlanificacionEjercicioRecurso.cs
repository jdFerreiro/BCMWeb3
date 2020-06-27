namespace BCMWeb.Core.Entities
{
    public partial class TblPbepruebaPlanificacionEjercicioRecurso
    {
        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public long IdEjercicio { get; set; }
        public long IdRecurso { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public string Responsable { get; set; }

        public virtual TblPbepruebaPlanificacion Id { get; set; }
        public virtual TblPbepruebaPlanificacionEjercicio IdNavigation { get; set; }
    }
}
