namespace BCMWeb.Core.Entities
{
    public partial class TblBcprespuestaRecurso
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBcp { get; set; }
        public long IdRespuestaRecurso { get; set; }
        public short Cantidad { get; set; }
        public string Nombre { get; set; }

        public virtual TblBcpdocumento Id { get; set; }
    }
}
