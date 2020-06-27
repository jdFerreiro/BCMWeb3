namespace BCMWeb.Core.Entities
{
    public partial class TblBiagranImpacto
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }
        public long IdGranImpacto { get; set; }
        public int IdMes { get; set; }
        public string Observacion { get; set; }
        public string Explicacion { get; set; }

        public virtual TblBiaproceso Id { get; set; }
        public virtual TblMes IdMesNavigation { get; set; }
    }
}
