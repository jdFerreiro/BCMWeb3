namespace BCMWeb.Core.Entities
{
    public partial class TblBiacadenaServicio
    {
        public long IdEmpresa { get; set; }
        public long IdCadenaServicio { get; set; }
        public string Descripcion { get; set; }

        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
    }
}
