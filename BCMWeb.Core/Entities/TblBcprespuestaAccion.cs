namespace BCMWeb.Core.Entities
{
    public partial class TblBcprespuestaAccion
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBcp { get; set; }
        public long IdBcprespuestaAccion { get; set; }
        public long IdPersona { get; set; }
        public short NivelEscala { get; set; }
        public string NombreEscala { get; set; }

        public virtual TblBcpdocumento Id { get; set; }
    }
}
