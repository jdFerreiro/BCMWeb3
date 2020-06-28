namespace BCMWeb.Core.Entities
{
    public partial class PMTScheduleUpdateTypeCulture
    {
        public string Culture { get; set; }
        public short UpdateTypeId { get; set; }
        public string Description { get; set; }

        public virtual PMTScheduleUpdateType PMTScheduleUpdateTypeInfo { get; set; }
    }
}
