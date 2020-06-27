namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaTipoTelefono
    {
        public string Culture { get; set; }
        public long IdTipoTelefono { get; set; }
        public string Descripcion { get; set; }

        public virtual TblTipoTelefono IdTipoTelefonoNavigation { get; set; }
    }
}
