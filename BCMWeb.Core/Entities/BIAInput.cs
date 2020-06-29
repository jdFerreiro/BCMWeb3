namespace BCMWeb.Core.Entities
{
    public class BIAInput : BaseEntity
    {
        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public long InputId { get; set; }
        public string Unit { get; set; }
        public string Event { get; set; }
        public string Responsable { get; set; }

        public virtual BIAProcess BIAProcessInfo { get; set; }
    }
}
