namespace BCMWeb.Core.Entities
{
    public class PMTScheduleUpdateTypeCulture : BaseEntity
    {
        public string Culture { get; set; }
        public short UpdateTypeId { get; set; }
        public string Description { get; set; }

        public virtual PMTScheduleUpdateType PMTScheduleUpdateTypeInfo { get; set; }
    }
}
