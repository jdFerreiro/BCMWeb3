namespace BCMWeb.Core.Entities
{
    public partial class BIAPrimaryBackup
    {
        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public long BackupId { get; set; }
        public string Location { get; set; }

        public virtual BIAProcess BIAProcessInfo { get; set; }
    }
}
