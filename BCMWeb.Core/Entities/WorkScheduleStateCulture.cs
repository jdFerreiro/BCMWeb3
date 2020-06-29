namespace BCMWeb.Core.Entities
{
    public class WorkScheduleStateCulture : BaseEntity
    {
        public string Culture { get; set; }
        public short WorkScheduleStateId { get; set; }
        public string Description { get; set; }

        public virtual WorkScheduleState WorkScheduleStateInfo { get; set; }
    }
}
