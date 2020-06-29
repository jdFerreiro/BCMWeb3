namespace BCMWeb.Core.Entities
{
    public class BCPRestoreInfraestructure : BaseEntity
    {
        public long CompanyId { get; set; }
        public long BCPDocumentId { get; set; }
        public long BCPRestoreInfraestructureId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public virtual BCPDocument BCPDocumentInfo { get; set; }
    }
}
