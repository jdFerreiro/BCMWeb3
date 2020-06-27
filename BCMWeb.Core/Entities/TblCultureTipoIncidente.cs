namespace BCMWeb.Core.Entities
{
    public partial class TblCultureTipoIncidente
    {
        public string Culture { get; set; }
        public int IdTipoIncidente { get; set; }
        public string Descripcion { get; set; }

        public virtual TblTipoIncidente IdTipoIncidenteNavigation { get; set; }
    }
}
