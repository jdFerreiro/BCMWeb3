namespace BCMWeb.Core.Entities
{
    public partial class BIAComment
    {
        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long CommentId { get; set; }
        public string Description { get; set; }

        public virtual BIADocument BIADocumentInfo { get; set; }
    }
}
