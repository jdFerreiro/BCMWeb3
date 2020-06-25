namespace BCMWeb.Core.Entities
{
    public class BIAProcesoAlterno
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdProceso { get; set; }
        public long IdProcesoAlterno { get; set; }
        public string ProcesoAlterno { get; set; }
    }
}
