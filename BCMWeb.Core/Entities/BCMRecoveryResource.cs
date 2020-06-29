namespace BCMWeb.Core.Entities
{
    public class BCMRecoveryResource : BaseEntity
    {
        public long CompanyId { get; set; }
        public long BCPDocumentId { get; set; }
        public long RecoveryResourceId { get; set; }
        public short Quantity { get; set; }
        public string Name { get; set; }

        public virtual BCPDocument BCPDocumentInfo { get; set; }
    }
}
