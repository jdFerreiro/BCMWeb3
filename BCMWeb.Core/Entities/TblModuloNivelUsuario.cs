namespace BCMWeb.Core.Entities
{
    public partial class TblModuloNivelUsuario
    {
        public long IdEmpresa { get; set; }
        public long IdNivelUsuario { get; set; }
        public long IdModulo { get; set; }
        public bool Actualizar { get; set; }
        public bool Eliminar { get; set; }

        public virtual TblModulo Id { get; set; }
        public virtual TblEmpresa IdEmpresaNavigation { get; set; }
        public virtual TblNivelUsuario IdNivelUsuarioNavigation { get; set; }
    }
}
