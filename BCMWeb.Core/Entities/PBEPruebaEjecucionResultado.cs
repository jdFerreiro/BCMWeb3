namespace BCMWeb.Core.Entities
{
    public class PBEPruebaEjecucionResultado
    {
        public long IdEmpresa { get; set; }
        public long IdPlanificacion { get; set; }
        public long IdContenido { get; set; }
        public byte[] Contenido { get; set; }
    }
}
