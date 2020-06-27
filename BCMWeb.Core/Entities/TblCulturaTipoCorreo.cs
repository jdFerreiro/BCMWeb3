namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaTipoCorreo
    {
        public string Culture { get; set; }
        public long IdTipoCorreo { get; set; }
        public string Descripcion { get; set; }

        public virtual TblTipoCorreo IdTipoCorreoNavigation { get; set; }
    }
}
