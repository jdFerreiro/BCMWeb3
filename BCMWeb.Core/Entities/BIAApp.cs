namespace BCMWeb.Core.Entities
{
    public class BIAApp : BaseEntity
    {
        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public long AppId { get; set; }
        public string Name { get; set; }
        public string User { get; set; }

        public virtual BIAProcess BIAProcessInfo { get; set; }
    }
}
