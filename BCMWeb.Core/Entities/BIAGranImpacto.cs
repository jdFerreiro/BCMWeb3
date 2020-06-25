namespace BCMWeb.Core.Entities
{
    public class BIAGranImpacto
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdProceso { get; set; }
        public long IdGranImpacto { get; set; }
        public int IdMes { get; set; }
        public string Observacion { get; set; }
        public string Explicacion { get; set; }
    }
}
