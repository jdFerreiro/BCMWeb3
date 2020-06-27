namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaEstadoUsuario
    {
        public string Culture { get; set; }
        public short IdEstadoUsuario { get; set; }
        public string Descripcion { get; set; }

        public virtual TblEstadoUsuario IdEstadoUsuarioNavigation { get; set; }
    }
}
