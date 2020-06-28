namespace BCMWeb.Core.Entities
{
    public partial class BIARPO
    {
        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public long RPOId { get; set; }
        public string Comments { get; set; }
        public long FrecuencyTypeId { get; set; }
        public long ScaleId { get; set; }

        public virtual BIAProcess BIAProcessInfo { get; set; }
        public virtual Scale ScaleInfo { get; set; }
        public virtual FrecuencyType FrecuencyTypeInfo { get; set; }
    }
}
