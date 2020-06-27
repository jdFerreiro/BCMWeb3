namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaPais
    {
        public string Culture { get; set; }
        public long IdPais { get; set; }
        public string Nombre { get; set; }

        public virtual TblPais IdPaisNavigation { get; set; }
    }
}
