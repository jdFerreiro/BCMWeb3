namespace BCMWeb.Core.Entities
{
    public class BCPRestauracionEquipo
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBCP { get; set; }
        public long IdBCPRestauracionEquipo { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
    }
}
