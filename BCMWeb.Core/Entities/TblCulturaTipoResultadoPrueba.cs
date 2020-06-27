namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaTipoResultadoPrueba
    {
        public string Culture { get; set; }
        public int IdTipoResultadoPrueba { get; set; }
        public string Descripcion { get; set; }

        public virtual TblTipoResultadoPrueba IdTipoResultadoPruebaNavigation { get; set; }
    }
}
