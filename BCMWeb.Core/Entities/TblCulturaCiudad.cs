namespace BCMWeb.Core.Entities
{
    public partial class TblCulturaCiudad
    {
        public string Culture { get; set; }
        public long IdPais { get; set; }
        public long IdEstado { get; set; }
        public long IdCiudad { get; set; }
        public string Nombre { get; set; }

        public virtual TblCiudad Id { get; set; }
    }
}
