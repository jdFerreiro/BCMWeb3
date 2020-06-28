namespace BCMWeb.Core.Entities
{
    public partial class BIADocumentation
    {
        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public long DocumentId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public virtual BIAProcess BIAPRocessInfo { get; set; }
    }
}
