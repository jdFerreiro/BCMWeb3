namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaTipoImpacto
    {
        public string Culture { get; set; }
        public int IdTipoImpacto { get; set; }
        public string Descripcion { get; set; }

        public virtual TblTipoImpacto IdTipoImpactoNavigation { get; set; }
    }
}
