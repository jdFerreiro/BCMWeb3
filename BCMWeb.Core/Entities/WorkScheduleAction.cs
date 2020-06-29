using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class WorkScheduleAction : BaseEntity
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
