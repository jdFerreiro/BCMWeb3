namespace BCMWeb.Core.Entities
{
    public class BIAKeyPerson : BaseEntity
    {
        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public long KeyPersonId { get; set; }
        public long DocumentId { get; set; }
        public long DocumentTypeId { get; set; }

        public virtual Document DocumentInfo { get; set; }
        public virtual DocumentKeyPerson DocumentKeyPersonInfo { get; set; }
        public virtual BIAProcess BIAProcessInfo { get; set; }
    }
}
