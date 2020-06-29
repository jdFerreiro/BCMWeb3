namespace BCMWeb.Core.Entities
{
    public class EmailFormat : BaseEntity
    {
        public long CompanyId { get; set; }
        public long MenuCodeId { get; set; }
        public int EmailId { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public string EmailBody { get; set; }

        public virtual Company CompanyInfo { get; set; }
    }
}
