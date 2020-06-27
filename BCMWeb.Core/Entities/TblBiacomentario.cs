namespace BCMWeb.Core.Entities
{
    public partial class TblBiacomentario
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdComentario { get; set; }
        public string Descripcion { get; set; }

        public virtual TblBiadocumento Id { get; set; }
    }
}
