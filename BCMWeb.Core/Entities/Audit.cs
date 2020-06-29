using System;

namespace BCMWeb.Core.Entities
{
    public class Audit : BaseEntity
    {
        public long AuditId { get; set; }
        public long? CompanyId { get; set; }
        public long? DocumentId { get; set; }
        public long? DocumentTypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string IPAddress { get; set; }
        public string Message { get; set; }
        public string Action { get; set; }
        public long? UserId { get; set; }
        public bool FromBussiness { get; set; }
        public string UpdateData { get; set; }

        public virtual Document DocumentInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
        public virtual User UserInfo { get; set; }
    }
}
