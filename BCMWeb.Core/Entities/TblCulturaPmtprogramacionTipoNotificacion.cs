namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaPmtprogramacionTipoNotificacion
    {
        public string Cultura { get; set; }
        public short IdTipoNotificacion { get; set; }
        public string Descripcion { get; set; }

        public virtual TblPmtprogramacionTipoNotificacion IdTipoNotificacionNavigation { get; set; }
    }
}
