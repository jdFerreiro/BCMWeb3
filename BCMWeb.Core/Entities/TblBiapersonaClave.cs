namespace BCMWeb.Core.Entities
{
    public partial class TblBiapersonaClave
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }
        public long IdPersonaClave { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }

        public virtual TblDocumento Id { get; set; }
        public virtual TblDocumentoPersonaClave Id1 { get; set; }
        public virtual TblBiaproceso IdNavigation { get; set; }
    }
}
