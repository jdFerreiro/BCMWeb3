namespace BCMWeb.Core.Entities
{
    public class BIAAlternateProcess : BaseEntity
    {
        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public long AlternateProcessId { get; set; }
        public string AlternateProcess { get; set; }

        public virtual BIAProcess BIAProcessInfo { get; set; }
    }
}
