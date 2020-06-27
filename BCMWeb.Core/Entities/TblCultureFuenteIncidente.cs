namespace BCMWeb.Core.Entities
{
    public partial class TblCultureFuenteIncidente
    {
        public string Culture { get; set; }
        public int IdFuenteIncidente { get; set; }
        public string Descripcion { get; set; }

        public virtual TblFuenteIncidente IdFuenteIncidenteNavigation { get; set; }
    }
}
