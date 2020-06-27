namespace BCMWeb.Core.Entities
{
    public partial class TblBiaamenaza
    {
        public long IdEmpresa { get; set; }
        public long IdDocumento { get; set; }
        public long IdProceso { get; set; }
        public long IdAmenaza { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdTipoDocumento { get; set; }
        public string Descripcion { get; set; }
        public string Evento { get; set; }
        public string TipoControlImplantado { get; set; }
        public string ControlesImplantar { get; set; }
        public short? Probabilidad { get; set; }
        public short? Impacto { get; set; }
        public short? Control { get; set; }
        public short? Severidad { get; set; }
        public string Fuente { get; set; }
        public short? Estado { get; set; }

        public virtual TblImpactoRiesgo I { get; set; }
        public virtual TblDocumento Id { get; set; }
        public virtual TblBiaproceso IdNavigation { get; set; }
        public virtual TblControlRiesgo TblControlRiesgo { get; set; }
        public virtual TblEstadoRiesgo TblEstadoRiesgo { get; set; }
        public virtual TblFuenteRiesgo TblFuenteRiesgo { get; set; }
        public virtual TblProbabilidadRiesgo TblProbabilidadRiesgo { get; set; }
        public virtual TblSeveridadRiesgo TblSeveridadRiesgo { get; set; }
    }
}
