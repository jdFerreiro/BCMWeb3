namespace BCMWeb.Core.Entities
{
    public partial class WorkScheduleStateCulture
    {
        public string Culture { get; set; }
        public short WorkScheduleStateId { get; set; }
        public string Description { get; set; }

        public virtual WorkScheduleState WorkScheduleStateInfo { get; set; }
    }
}
