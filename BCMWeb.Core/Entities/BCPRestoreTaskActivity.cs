namespace BCMWeb.Core.Entities
{
    public partial class BCPRestoreTaskActivity
    {
        public long CompanyId { get; set; }
        public long BCPDocumentId { get; set; }
        public long BCPRestoreTaskId { get; set; }
        public long BCPRestoreTaskActivityId { get; set; }
        public string Description { get; set; }
        public bool IsProcessed { get; set; }

        public virtual BCPRestoreTask BCPRestoreTaskInfo { get; set; }
    }
}
