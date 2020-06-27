namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaTipoUbicacionInformacion
    {
        public string Culture { get; set; }
        public int IdTipoUbicacionInformacion { get; set; }
        public string Descripcion { get; set; }

        public virtual TblTipoUbicacionInformacion IdTipoUbicacionInformacionNavigation { get; set; }
    }
}
