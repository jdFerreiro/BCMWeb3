using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class WorkScheduleAction
    {
        public WorkScheduleAction()
        {
            WorkSchedules = new HashSet<WorkSchedule>();
            WorkScheduleAudits = new HashSet<WorkScheduleAudit>();
        }

        public long CompanyId { get; set; }
        public long ScheduleActionId { get; set; }
        public string Description { get; set; }

        public virtual Company CompanyInfo { get; set; }
        public virtual ICollection<WorkSchedule> WorkSchedules { get; set; }
        public virtual ICollection<WorkScheduleAudit> WorkScheduleAudits { get; set; }
    }
}
