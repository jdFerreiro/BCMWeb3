namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaTipoInterdependencia
    {
        public string Culture { get; set; }
        public int IdTipoInterdependencia { get; set; }
        public string Descripcion { get; set; }

        public virtual TblTipoInterdependencia IdTipoInterdependenciaNavigation { get; set; }
    }
}
