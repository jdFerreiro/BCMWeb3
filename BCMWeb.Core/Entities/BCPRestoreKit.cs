namespace BCMWeb.Core.Entities
{
    public partial class BCPRestoreKit
    {
        public long CompanyId { get; set; }
        public long BCPDocumentId { get; set; }
        public long BCPRestoreKitId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public virtual BCPDocument BCPDocumentInfo { get; set; }
    }
}
