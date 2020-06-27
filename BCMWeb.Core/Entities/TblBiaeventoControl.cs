namespace BCMWeb.Core.Entities
{
    public partial class TblBiaeventoControl
    {
        public long IdEmpresa { get; set; }
        public long IdDocumentoBia { get; set; }
        public long IdProceso { get; set; }
        public long IdAmenaza { get; set; }
        public long IdAmenazaEvento { get; set; }
        public long IdEventoControl { get; set; }
        public string Descripcion { get; set; }
        public bool Implantado { get; set; }

        public virtual TblBiaamenazaEvento Id { get; set; }
    }
}
