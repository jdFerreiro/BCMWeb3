namespace BCMWeb.Core.Entities
{
    public partial class BIAProcessBackupPerson
    {
        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long PersonId { get; set; }
        public long ProcessId { get; set; }

        public virtual Person PersonInfo { get; set; }
        public virtual BIAProcess BIAProcessInfo { get; set; }
    }
}
