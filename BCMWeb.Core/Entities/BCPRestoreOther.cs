namespace BCMWeb.Core.Entities
{
    public class BCPRestoreOther : BaseEntity
    {
        public long CompanyId { get; set; }
        public long BCPDocumentId { get; set; }
        public long BCPRestoreOtherId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public virtual BCPDocument BCPDocumentInfo { get; set; }
    }
}
