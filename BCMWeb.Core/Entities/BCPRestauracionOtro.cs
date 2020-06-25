namespace BCMWeb.Core.Entities
{
    public class BCPRestauracionOtro
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBCP { get; set; }
        public long IdBCPRestauracionOtro { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
    }
}
