using System;

namespace BCMWeb.Core.Entities
{
    public class DocumentApproval : BaseEntity
    {
        public long CompanyId { get; set; }
        public long DocumentId { get; set; }
        public long DocumentType { get; set; }
        public long ApprovalId { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public long? PersonId { get; set; }
        public bool IsProcessed { get; set; }
        public bool? IsApproved { get; set; }

        public virtual Person PersonInfo { get; set; }
        public virtual Document DocumentInfo { get; set; }
    }
}
