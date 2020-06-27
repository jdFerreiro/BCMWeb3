namespace BCMWeb.Core.Entities
{
    public partial class TblPpefrecuencia
    {
        public long IdEmpresa { get; set; }
        public long IdDocumento { get; set; }
        public long IdTipoDocumento { get; set; }
        public long IdPpefrecuencia { get; set; }
        public string TipoPrueba { get; set; }
        public string Participantes { get; set; }
        public string Proposito { get; set; }
        public long IdTipoFrecuencia { get; set; }

        public virtual TblDocumento Id { get; set; }
        public virtual TblTipoFrecuencia IdTipoFrecuenciaNavigation { get; set; }
    }
}
