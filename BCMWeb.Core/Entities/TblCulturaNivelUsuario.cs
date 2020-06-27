namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaNivelUsuario
    {
        public string Culture { get; set; }
        public long IdNivelUsuario { get; set; }
        public string Descripcion { get; set; }

        public virtual TblNivelUsuario IdNivelUsuarioNavigation { get; set; }
    }
}
