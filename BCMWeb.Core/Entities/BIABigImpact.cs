namespace BCMWeb.Core.Entities
{
    public class BIABigImpact : BaseEntity
    {
        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public long BigImpactId { get; set; }
        public int MonthId { get; set; }
        public string Comments { get; set; }
        public string Explain { get; set; }

        public virtual BIAProcess BIAProcessInfo { get; set; }
        public virtual Month MonthInfo { get; set; }
    }
}
