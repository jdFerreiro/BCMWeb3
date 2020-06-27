namespace BCMWeb.Core.Entities
{
    public partial class TblBiarespaldoPrimario
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }
        public long IdRespaldo { get; set; }
        public string Ubicacion { get; set; }

        public virtual TblBiaproceso Id { get; set; }
    }
}
