namespace BCMWeb.Core.Entities
{
    public partial class TblBiaaplicacion
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }
        public long IdAplicacion { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }

        public virtual TblBiaproceso Id { get; set; }
    }
}
