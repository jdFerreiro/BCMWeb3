using System;

namespace BCMWeb.Core.Entities
{
    public class AuditoriaProcesoCritico
    {
        public long IdProceso { get; set; }
        public long IdAuditoriaProcesoCritico { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool EstadoAnterior { get; set; }
        public bool EstadoActual { get; set; }
        public long IdEmpresa { get; set; }

    }
}
