namespace BCMWeb.Core.Entities
{
    public class BCPResumptionTaskActivity : BaseEntity
    {
        public long CompanyId { get; set; }
        public long BCPDocumentId { get; set; }
        public long BCPResumptionTaskId { get; set; }
        public long BCPResumptionTaskActivityId { get; set; }
        public string Description { get; set; }
        public bool IsProcessed { get; set; }

        public virtual BCPResumptionTask BCPResumptionTaskInfo { get; set; }
    }
}
