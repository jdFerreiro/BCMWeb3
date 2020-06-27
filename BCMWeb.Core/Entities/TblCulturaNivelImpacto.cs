namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaNivelImpacto
    {
        public string Culture { get; set; }
        public int IdNivelImpacto { get; set; }
        public string Descripcion { get; set; }

        public virtual TblNivelImpacto IdNivelImpactoNavigation { get; set; }
    }
}
