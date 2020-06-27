namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaTipoTablaContenido
    {
        public string Culture { get; set; }
        public int IdTipoTablaContenido { get; set; }
        public string Descripcion { get; set; }

        public virtual TblTipoTablaContenido IdTipoTablaContenidoNavigation { get; set; }
    }
}
