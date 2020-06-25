namespace BCMWeb.Core.Entities
{
    public class UnidadOrganizativa
    {
        public long IdEmpresa { get; set; }
        public long IdUnidadOrganizativa { get; set; }
        public string Nombre { get; set; }
        public long IdUnidadPadre { get; set; }
    }
}
