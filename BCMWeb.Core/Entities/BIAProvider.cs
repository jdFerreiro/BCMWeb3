namespace BCMWeb.Core.Entities
{
    public partial class BIAProvider
    {
        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public long ProviderId { get; set; }
        public string Organization { get; set; }
        public string Service { get; set; }
        public string Contact { get; set; }

        public virtual BIAProcess BIAProcessInfo { get; set; }
    }
}
