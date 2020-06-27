namespace BCMWeb.Core.Entities
{
    public partial class TblProducto
    {
        public long IdEmpresa { get; set; }
        public long IdProducto { get; set; }
        public string Nombre { get; set; }

        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
    }
}
