namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaTipoDireccion
    {
        public string Culture { get; set; }
        public long IdTipoDireccion { get; set; }
        public string Descripcion { get; set; }

        public virtual TblTipoDireccion IdTipoDireccionNavigation { get; set; }
    }
}
