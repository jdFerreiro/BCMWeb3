namespace BCMWeb.Core.Entities
{
    public partial class TblBiaunidadTrabajoPersonas
    {
        public long IdEmpresa { get; set; }
        public long IdUnidadTrabajo { get; set; }
        public long IdUnidadTrabajoProceso { get; set; }
        public long IdUnidadPersona { get; set; }
        public long IdClienteProceso { get; set; }
        public string Nombre { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }

        public virtual TblBiaunidadTrabajoProceso Id { get; set; }
        public virtual TblBiaclienteProceso IdNavigation { get; set; }
    }
}
