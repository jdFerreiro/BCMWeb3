namespace BCMWeb.Core.Entities
{
    public class BCPRespuestaAccion
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBCP { get; set; }
        public long IdBCPRespuestaAccion { get; set; }
        public long IdPersona { get; set; }
        public short NivelEscala { get; set; }
        public string NombreEscala { get; set; }
    }
}
