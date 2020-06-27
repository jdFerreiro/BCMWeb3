namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaMes
    {
        public string Culture { get; set; }
        public int IdMes { get; set; }
        public string Descripcion { get; set; }

        public virtual TblMes IdMesNavigation { get; set; }
    }
}
