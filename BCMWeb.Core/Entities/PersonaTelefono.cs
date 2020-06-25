namespace BCMWeb.Core.Entities
{
    public class PersonaTelefono
    {
        public long IdEmpresa { get; set; }
        public long IdPersona { get; set; }
        public long IdPersonaTelefono { get; set; }
        public long IdTipoTelefono { get; set; }
        public string Telefono { get; set; }
    }
}
