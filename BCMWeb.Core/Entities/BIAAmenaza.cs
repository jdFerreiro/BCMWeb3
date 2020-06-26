namespace BCMWeb.Core.Entities
{
    public class BIAAmenaza
    {
        public long IdEmpresa { get; set; }
        public long IdDocumento { get; set; }
        public long IdProceso { get; set; }
        public long IdAmenaza { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdTipoDocumento { get; set; }
        public string Descripcion { get; set; }
        public string Evento { get; set; }
        public string TipoControlImplantado { get; set; }
        public string ControlesImplantar { get; set; }
        public short Probabilidad { get; set; }
        public short Impacto { get; set; }
        public short Control { get; set; }
        public short Severidad { get; set; }
        public string Fuente { get; set; }
        public short Estado { get; set; }
    }
}
