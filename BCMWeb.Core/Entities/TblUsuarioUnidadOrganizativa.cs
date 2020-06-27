namespace BCMWeb.Core.Entities
{
    public partial class TblUsuarioUnidadOrganizativa
    {
        public long IdEmpresa { get; set; }
        public long IdUnidadOrganizativa { get; set; }
        public long IdUsuario { get; set; }
        public long IdNivelUsuario { get; set; }

        public virtual TblUnidadOrganizativa Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual TblNivelUsuario IdNivelUsuarioNavigation { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
