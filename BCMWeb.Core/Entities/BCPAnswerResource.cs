namespace BCMWeb.Core.Entities
{
    public partial class BCPAnswerResource
    {
        public long CompanyId { get; set; }
        public long BCPDocumentId { get; set; }
        public long BCPAnswerResourceId { get; set; }
        public short Quantity { get; set; }
        public string Name { get; set; }

        public virtual BCPDocument BCPDocuments { get; set; }
    }
}
