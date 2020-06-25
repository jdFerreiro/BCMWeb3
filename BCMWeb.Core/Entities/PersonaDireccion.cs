namespace BCMWeb.Core.Entities
{
    public class PersonaDireccion
    {
        public long IdEmpresa { get; set; }
        public long IdPersona { get; set; }
        public long IdPersonaDireccion { get; set; }
        public long IdTipoDireccion { get; set; }
        public string Ubicacion { get; set; }
        public long IdPais { get; set; }
        public long IdEstado { get; set; }
        public long IdCiudad { get; set; }
    }
}
