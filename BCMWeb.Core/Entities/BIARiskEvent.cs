namespace BCMWeb.Core.Entities
{
    public partial class BIARiskEvent
    {
        public long RiskEventId { get; set; }
        public long CompanyId { get; set; }
        public short Probability { get; set; }
        public short Impact { get; set; }
        public short Control { get; set; }
        public long Severity { get; set; }
        public long RiskStateId { get; set; }
        public long RiskSourceId { get; set; }
    }
}
