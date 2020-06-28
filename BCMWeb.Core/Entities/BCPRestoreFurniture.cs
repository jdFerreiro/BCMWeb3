namespace BCMWeb.Core.Entities
{
    public partial class BCPRestoreFurniture
    {
        public long CompanyId { get; set; }
        public long BCPDocumentId { get; set; }
        public long BCPRestoreFurnitureId { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public virtual BCPDocument BCPDocumentInfo { get; set; }
    }
}
