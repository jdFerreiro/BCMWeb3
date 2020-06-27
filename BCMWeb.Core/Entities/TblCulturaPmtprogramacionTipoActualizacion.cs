namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaPmtprogramacionTipoActualizacion
    {
        public string Culture { get; set; }
        public short IdTipoActualizacion { get; set; }
        public string Descripcion { get; set; }

        public virtual TblPmtprogramacionTipoActualizacion IdTipoActualizacionNavigation { get; set; }
    }
}
