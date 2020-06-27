namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaTipoRespaldo
    {
        public string Culture { get; set; }
        public int IdTipoRespaldo { get; set; }
        public string Descripcion { get; set; }

        public virtual TblTipoRespaldo IdTipoRespaldoNavigation { get; set; }
    }
}
