namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaEstadoProceso
    {
        public string Culture { get; set; }
        public long IdEstadoProceso { get; set; }
        public string Descripcion { get; set; }

        public virtual TblEstadoProceso IdEstadoProcesoNavigation { get; set; }
    }
}
