namespace BCMWeb.Core.Entities
{
    public partial class TblBiainterdependencia
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }
        public long IdInterdependencia { get; set; }
        public string Organizacion { get; set; }
        public string Servicio { get; set; }
        public string Contacto { get; set; }

        public virtual TblBiaproceso Id { get; set; }
    }
}
