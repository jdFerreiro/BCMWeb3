namespace BCMWeb.Core.Entities
{
    public class Persona
    {
        public long IdPersona { get; set; }
        public long IdEmpresa { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public long IdUnidadOrganizativa { get; set; }
        public long IdCargo { get; set; }
        public long IdUsuario { get; set; }
    }
}
