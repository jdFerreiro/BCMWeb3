namespace BCMWeb.Core.Entities
{
    public class BIAEntrada
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdProceso { get; set; }
        public long IdEntrada { get; set; }
        public string Unidad { get; set; }
        public string Evento { get; set; }
        public string Responsable { get; set; }
    }
}
