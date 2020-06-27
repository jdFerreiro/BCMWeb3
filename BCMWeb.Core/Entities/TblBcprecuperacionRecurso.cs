namespace BCMWeb.Core.Entities
{
    public partial class TblBcprecuperacionRecurso
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBcp { get; set; }
        public long IdRecuperacionRecurso { get; set; }
        public short Cantidad { get; set; }
        public string Nombre { get; set; }

        public virtual TblBcpdocumento Id { get; set; }
    }
}
