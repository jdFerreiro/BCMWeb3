using System;

namespace BCMWeb.Core.Entities
{
    public partial class AuditCriticalProcess
    {
        public long ProcessId { get; set; }
        public long AuditCriticalProcessId { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool PreviousState { get; set; }
        public bool ActualState { get; set; }
        public long CompanyId { get; set; }
        public long UserId { get; set; }

        public virtual Company CompanyInfo { get; set; }
        public virtual User UserInfo { get; set; }
    }
}
