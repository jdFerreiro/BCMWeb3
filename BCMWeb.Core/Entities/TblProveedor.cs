namespace BCMWeb.Core.Entities
{
    public partial class TblProveedor
    {
        public long IdEmpresa { get; set; }
        public long IdProveedor { get; set; }
        public string Nombre { get; set; }

        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
    }
}
