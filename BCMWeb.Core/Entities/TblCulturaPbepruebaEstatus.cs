namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaPbepruebaEstatus
    {
        public string Cultura { get; set; }
        public short IdEstatus { get; set; }
        public string Descripcion { get; set; }

        public virtual TblPbepruebaEstatus IdEstatusNavigation { get; set; }
    }
}
