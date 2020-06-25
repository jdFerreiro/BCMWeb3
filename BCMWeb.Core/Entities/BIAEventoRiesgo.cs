using System;

namespace BCMWeb.Core.Entities
{
    public class BIAEventoRiesgo
    {
        public long IdEventoRiesgo { get; set; }
        public long IdEmpresa { get; set; }
        public Int16 Probabilidad { get; set; }
        public Int16 Impacto { get; set; }
        public Int16 Control { get; set; }
        public long Severidad { get; set; }
        public long IdEstadoRiesgo { get; set; }
        public long IdFuenteRiesgo { get; set; }
    }
}
