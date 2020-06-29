using System;

namespace BCMWeb.Core.Entities
{
    public class CriticalProcessAudit : BaseEntity
    {
        public long ProcessId { get; set; }
        public long CriticalProcessAuditId { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool PreviousState { get; set; }
        public bool ActualState { get; set; }
        public long CompanyId { get; set; }
        public long UserId { get; set; }

        public virtual Company CompanyInfo { get; set; }
        public virtual User UserInfo { get; set; }
    }
}
