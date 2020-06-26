namespace BCMWeb.Core.Entities
{
    public class BCPRecuperacionRecurso
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBCP { get; set; }
        public long IdRecuperacionRecurso { get; set; }
        public short Cantidad { get; set; }
        public string Nombre { get; set; }
    }
}
