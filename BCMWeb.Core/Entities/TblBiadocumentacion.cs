namespace BCMWeb.Core.Entities
{
    public partial class TblBiadocumentacion
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }
        public long IdDocumento { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }

        public virtual TblBiaproceso Id { get; set; }
    }
}
