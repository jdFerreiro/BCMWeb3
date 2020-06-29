using System;

namespace BCMWeb.Core.Entities
{
    public class PMTScheduleUser : BaseEntity
    {
        public long PMTScheduleId { get; set; }
        public long UserId { get; set; }
        public short? NotifyTypeId { get; set; }
        public DateTime? LastUpdateDate { get; set; }

        public virtual PMTSchedule PMTScheduleInfo { get; set; }
        public virtual PMTScheduleNotificationType PMTScheduleNotifyTypeInfo { get; set; }
        public virtual User UserInfo { get; set; }
    }
}
