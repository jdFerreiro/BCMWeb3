namespace BCMWeb.Core.Entities
{
    public partial class TblBiaeventoRiesgo
    {
        public long IdEventoRiesgo { get; set; }
        public long IdEmpresa { get; set; }
        public short Probabilidad { get; set; }
        public short Impacto { get; set; }
        public short Control { get; set; }
        public long Severidad { get; set; }
        public long IdEstadoRiesgo { get; set; }
        public long IdFuenteRiesgo { get; set; }
    }
}
