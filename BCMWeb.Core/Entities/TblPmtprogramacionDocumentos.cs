namespace BCMWeb.Core.Entities
{
    public partial class TblPmtprogramacionDocumentos
    {
        public long IdPmtprogramacion { get; set; }
        public long IdEmpresa { get; set; }
        public long IdModulo { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }

        public virtual TblModulo Id { get; set; }
        public virtual TblDocumento IdNavigation { get; set; }
        public virtual TblPmtprogramacion IdPmtprogramacionNavigation { get; set; }
    }
}
