namespace BCMWeb.Core.Entities
{
    public partial class TblBiaprocesoAlterno
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }
        public long IdProcesoAlterno { get; set; }
        public string ProcesoAlterno { get; set; }

        public virtual TblBiaproceso Id { get; set; }
    }
}
