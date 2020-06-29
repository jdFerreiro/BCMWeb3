using System;

namespace BCMWeb.Core.Entities
{
    public class WorkScheduleAudit : BaseEntity
    {
        public long CompanyId { get; set; }
        public long ActionId { get; set; }
        public long ActivityId { get; set; }
        public long StateChangeId { get; set; }
        public DateTime StateChangeDate { get; set; }
        public short State { get; set; }
        public long StateChangeUserId { get; set; }

        public virtual WorkScheduleState WorkScheduleStateInfo { get; set; }
        public virtual WorkScheduleAction WorkScheduleActionInfo { get; set; }
        public virtual WorkSchedule WorkScheduleInfo { get; set; }
        public virtual User UserInfo { get; set; }
    }
}
