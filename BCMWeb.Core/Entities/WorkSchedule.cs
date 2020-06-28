using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class WorkSchedule
    {
        public WorkSchedule()
        {
            WorkScheduleAudits = new HashSet<WorkScheduleAudit>();
        }

        public long CompanyId { get; set; }
        public long ActionId { get; set; }
        public long ActivityId { get; set; }
        public string Recommendation { get; set; }
        public string Responsable { get; set; }
        public DateTime ExecutionProposalDate { get; set; }
        public short Executed { get; set; }
        public long? ParentActivityId { get; set; }

        public virtual WorkScheduleState WorkScheduleStateInfo { get; set; }
        public virtual WorkScheduleAction WorkScheduleActionInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
        public virtual ICollection<WorkScheduleAudit> WorkScheduleAudits { get; set; }
    }
}
