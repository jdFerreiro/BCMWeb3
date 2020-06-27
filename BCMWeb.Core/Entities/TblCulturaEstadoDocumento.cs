namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaEstadoDocumento
    {
        public string Culture { get; set; }
        public long IdEstadoDocumento { get; set; }
        public string Descripcion { get; set; }

        public virtual TblEstadoDocumento IdEstadoDocumentoNavigation { get; set; }
    }
}
