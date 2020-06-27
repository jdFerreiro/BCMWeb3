namespace BCMWeb.Core.Entities
{
    public partial class TblBiaimpactoOperacional
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }
        public long IdImpactoOperacional { get; set; }
        public long? IdTipoFrecuencia { get; set; }
        public string ImpactoOperacional { get; set; }
        public string Descripcion { get; set; }
        public long? IdEscala { get; set; }
        public string UnidadTiempo { get; set; }

        public virtual TblBiaproceso Id { get; set; }
        public virtual TblEscala IdE { get; set; }
        public virtual TblTipoFrecuencia IdTipoFrecuenciaNavigation { get; set; }
    }
}
