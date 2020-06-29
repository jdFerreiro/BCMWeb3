namespace BCMWeb.Core.Entities
{
    public class BIAWRT : BaseEntity
    {
        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public long WRTId { get; set; }
        public string Comments { get; set; }
        public long? FrecuencyTypeId { get; set; }
        public long? ScaleId { get; set; }

        public virtual BIAProcess BiaProcessInfo { get; set; }
        public virtual Scale ScaleInfo { get; set; }
        public virtual FrecuencyType FrecuencyTypeInfo { get; set; }
    }
}
