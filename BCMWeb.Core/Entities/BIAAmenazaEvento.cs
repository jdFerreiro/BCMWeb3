namespace BCMWeb.Core.Entities
{
    public class BIAAmenazaEvento
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBIA { get; set; }
        public long IdProceso { get; set; }
        public long IdAmenaza { get; set; }
        public long IdAmenazaEvento { get; set; }
        public string Nombre { get; set; }
        public long IdEventoRiesgo { get; set; }
    }
}
