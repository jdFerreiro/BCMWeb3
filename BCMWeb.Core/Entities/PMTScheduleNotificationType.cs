using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class PMTScheduleNotificationType
    {
        public PMTScheduleNotificationType()
        {
            PMTScheduleNotificationTypeCultures = new HashSet<PMTScheduleNotificationTypeCulture>();
            PMTScheduleUsers = new HashSet<PMTScheduleUser>();
        }

        public short NotificationTypeId { get; set; }

        public virtual ICollection<PMTScheduleNotificationTypeCulture> PMTScheduleNotificationTypeCultures { get; set; }
        public virtual ICollection<PMTScheduleUser> PMTScheduleUsers { get; set; }
    }
}
