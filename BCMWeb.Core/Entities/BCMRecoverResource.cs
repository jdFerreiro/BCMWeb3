namespace BCMWeb.Core.Entities
{
    public partial class BCMRecoverResource
    {
        public long CompanyId { get; set; }
        public long BCPDocumentId { get; set; }
        public long RecoverResourceId { get; set; }
        public short Quantity { get; set; }
        public string Name { get; set; }

        public virtual BCPDocument BCPDocumentInfo { get; set; }
    }
}
