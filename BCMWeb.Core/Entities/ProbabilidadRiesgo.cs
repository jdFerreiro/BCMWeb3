using System;

namespace BCMWeb.Core.Entities
{
    public class ProbabilidadRiesgo
    {
        public long IdEmpresa { get; set; }
        public Int16 IdProbabilidad { get; set; }
        public string Nombre { get; set; }
        public string EtiquetaGrafico { get; set; }
    }
}
