namespace BCMWeb.Core.Entities
{
    public class BCPRestauracionMobiliario
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBCP { get; set; }
        public long IdRestauracionMobiliario { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
    }
}
