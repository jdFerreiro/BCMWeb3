using System;

namespace BCMWeb.Core.Entities
{
    public class Iniciativas
    {
        public long IdEmpresa { get; set; }
        public long IdIniciativa { get; set; }
        public int NroIniciativa { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public long IdUnidadOrganizativa { get; set; }
        public string UnidadOrganizativa { get; set; }
        public string NombreResponsable { get; set; }
        public DateTime FechaInicioEstimada { get; set; }
        public DateTime FechaInicioReal { get; set; }
        public DateTime FechaCierreEstimada { get; set; }
        public DateTime FechaCierreReal { get; set; }
        public decimal PresupuestoEstimado { get; set; }
        public decimal PresupuestoReal { get; set; }
        public Int16 IdEstatusIniciativa { get; set; }
        public string Observacion { get; set; }
        public Int16 IdPrioridad { get; set; }
        public decimal MontoAbonado { get; set; }
        public decimal MontoPendiente { get; set; }
        public decimal PorcentajeAvance { get; set; }
        public int HorasEstimadas { get; set; }
        public int HorasConsumidas { get; set; }
    }
}
