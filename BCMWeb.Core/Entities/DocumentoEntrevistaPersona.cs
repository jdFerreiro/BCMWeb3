namespace BCMWeb.Core.Entities
{
    public class DocumentoEntrevistaPersona
    {
        public long IdEmpresa { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }
        public long IdEntrevista { get; set; }
        public long IdPersonaEntrevista { get; set; }
        public bool EsEntrevistador { get; set; }
        public string Nombre { get; set; }
        public string Empresa { get; set; }
    }
}
