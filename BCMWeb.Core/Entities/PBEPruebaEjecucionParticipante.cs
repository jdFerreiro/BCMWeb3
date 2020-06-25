namespace BCMWeb.Core.Entities
{
    public class PBEPruebaEjecucionParticipante
    {
        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public long IdParticipante { get; set; }
        public string Empresa { get; set; }
        public string Nombre { get; set; }
        public bool Responsable { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public long IdPlanificacionParticipante { get; set; }
    }
}
