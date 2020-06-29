namespace BCMWeb.Core.Entities
{
    public class PMTScheduleNotificationTypeCulture : BaseEntity
    {
        public string Culture { get; set; }
        public short NotificationTypeId { get; set; }
        public string Description { get; set; }

        public virtual PMTScheduleNotificationType NotificationTypeInfo { get; set; }
    }
}
