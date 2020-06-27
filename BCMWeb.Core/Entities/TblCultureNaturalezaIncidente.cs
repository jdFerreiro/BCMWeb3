namespace BCMWeb.Core.Entities
{
    public partial class TblCultureNaturalezaIncidente
    {
        public string Culture { get; set; }
        public int IdNaturalezaIncidente { get; set; }
        public string Descripcion { get; set; }

        public virtual TblNaturalezaIncidente IdNaturalezaIncidenteNavigation { get; set; }
    }
}
