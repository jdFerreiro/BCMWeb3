namespace BCMWeb.Core.Entities
{
    public partial class TblModuloUsuario
    {
        public long IdEmpresa { get; set; }
        public long IdModulo { get; set; }
        public long IdUsuario { get; set; }
        public bool Actualizar { get; set; }
        public bool Eliminar { get; set; }

        public virtual TblModulo Id { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
