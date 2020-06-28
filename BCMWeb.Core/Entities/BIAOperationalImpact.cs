namespace BCMWeb.Core.Entities
{
    public partial class BIAOperationalImpact
    {
        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public long OperationalImpactId { get; set; }
        public long? FrecuencyTypeId { get; set; }
        public string OperationalImpact { get; set; }
        public string Description { get; set; }
        public long? ScaleId { get; set; }
        public string TimeUnit { get; set; }

        public virtual BIAProcess ProcessInfo { get; set; }
        public virtual Scale ScaleInfo { get; set; }
        public virtual FrecuencyType FrecuencyTypeInfo { get; set; }
    }
}
