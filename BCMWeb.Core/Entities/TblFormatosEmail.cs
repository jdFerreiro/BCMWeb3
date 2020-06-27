namespace BCMWeb.Core.Entities
{
    public partial class TblFormatosEmail
    {
        public long IdEmpresa { get; set; }
        public long IdCodigoModulo { get; set; }
        public int IdCorreo { get; set; }
        public string Descripcion { get; set; }
        public string Subject { get; set; }
        public string EmailBody { get; set; }

        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
    }
}
