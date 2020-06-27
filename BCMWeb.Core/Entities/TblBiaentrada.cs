namespace BCMWeb.Core.Entities
{
    public partial class TblBiaentrada
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }
        public long IdEntrada { get; set; }
        public string Unidad { get; set; }
        public string Evento { get; set; }
        public string Responsable { get; set; }

        public virtual TblBiaproceso Id { get; set; }
    }
}
