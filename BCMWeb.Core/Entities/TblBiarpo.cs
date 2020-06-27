namespace BCMWeb.Core.Entities
{
    public partial class TblBiarpo
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }
        public long IdRpo { get; set; }
        public string Observacion { get; set; }
        public long IdTipoFrecuencia { get; set; }
        public long IdEscala { get; set; }

        public virtual TblBiaproceso Id { get; set; }
        public virtual TblEscala IdE { get; set; }
        public virtual TblTipoFrecuencia IdTipoFrecuenciaNavigation { get; set; }
    }
}
