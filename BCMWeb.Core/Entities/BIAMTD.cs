namespace BCMWeb.Core.Entities
{
    public class BIAMTD : BaseEntity
    {
        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public long MTDId { get; set; }
        public string Comments { get; set; }
        public long? FrecuencyTypeId { get; set; }
        public long? ScaleId { get; set; }

        public virtual BIAProcess BIAProcessInfo { get; set; }
        public virtual Scale ScaleInfo { get; set; }
        public virtual FrecuencyType FrecuencyTypeInfo { get; set; }
    }
}
