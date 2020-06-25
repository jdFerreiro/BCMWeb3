using System;

namespace BCMWeb.Core.Entities
{
    public class Incidentes
    {
        public long IdEmpresa { get; set; }
        public long IdIncidente { get; set; }
        public int IdTipoIncidente { get; set; }
        public int IdNaturalezaIncidente { get; set; }
        public int IdFuenteIncidente { get; set; }
        public DateTime FechaIncidente { get; set; }
        public string Descripcion { get; set; }
        public string LugarIncidente { get; set; }
        public int Duracion { get; set; }
        public string NombreReportero { get; set; }
        public string NombreSolucionador { get; set; }
        public string Observaciones { get; set; }
    }
}
