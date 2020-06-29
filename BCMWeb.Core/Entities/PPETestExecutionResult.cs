namespace BCMWeb.Core.Entities
{
    public class PPETestExecutionResult : BaseEntity
    {
        public long CompanyId { get; set; }
        public long ScheduleId { get; set; }
        public long ContentId { get; set; }
        public byte[] Content { get; set; }

        public virtual PPETestExecution PPETestExecutionInfo { get; set; }
    }
}
