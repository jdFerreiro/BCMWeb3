namespace BCMWeb.Core.Entities
{
    public partial class TblBiapersonaRespaldoProceso
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdPersona { get; set; }
        public long IdProceso { get; set; }

        public virtual TblPersona Id { get; set; }
        public virtual TblBiaproceso IdNavigation { get; set; }
    }
}
