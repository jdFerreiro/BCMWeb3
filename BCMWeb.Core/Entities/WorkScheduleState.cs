using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class WorkScheduleState
    {
        public WorkScheduleState()
        {
            WorkScheduleStateCultures = new HashSet<WorkScheduleStateCulture>();
            Intiatives = new HashSet<Intiative>();
            WorkSchedules = new HashSet<WorkSchedule>();
            WorkScheduleAudits = new HashSet<WorkScheduleAudit>();
        }

        public short WorkScheduleStateId { get; set; }

        public virtual ICollection<WorkScheduleStateCulture> WorkScheduleStateCultures { get; set; }
        public virtual ICollection<Intiative> Intiatives { get; set; }
        public virtual ICollection<WorkSchedule> WorkSchedules { get; set; }
        public virtual ICollection<WorkScheduleAudit> WorkScheduleAudits { get; set; }
    }
}
