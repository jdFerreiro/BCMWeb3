namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaTipoFrecuencia
    {
        public string Culture { get; set; }
        public long IdTipoFrecuencia { get; set; }
        public string Descripcion { get; set; }

        public virtual TblTipoFrecuencia IdTipoFrecuenciaNavigation { get; set; }
    }
}
