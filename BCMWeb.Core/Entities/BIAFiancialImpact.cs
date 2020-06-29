namespace BCMWeb.Core.Entities
{
    public class BIAFiancialImpact : BaseEntity
    {
        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public long FinancialImpactId { get; set; }
        public long? FrecuencyTypeId { get; set; }
        public string Description { get; set; }
        public string Impact { get; set; }
        public long? ScaleId { get; set; }
        public string TimeUnit { get; set; }

        public virtual BIAProcess BIAProcessInfo { get; set; }
        public virtual Scale ScaleInfo { get; set; }
        public virtual FrecuencyType FrecuencyTypeInfo { get; set; }
    }
}
