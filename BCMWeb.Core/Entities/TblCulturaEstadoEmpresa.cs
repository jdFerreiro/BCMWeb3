namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaEstadoEmpresa
    {
        public string Culture { get; set; }
        public long IdEstadoEmpresa { get; set; }
        public string Descripcion { get; set; }

        public virtual TblEstadoEmpresa IdEstadoEmpresaNavigation { get; set; }
    }
}
