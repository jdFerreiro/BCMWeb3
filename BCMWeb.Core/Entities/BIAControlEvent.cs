namespace BCMWeb.Core.Entities
{
    public partial class BIAControlEvent
    {
        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public long ThreatId { get; set; }
        public long ThreatEventId { get; set; }
        public long ControlEventId { get; set; }
        public string Description { get; set; }
        public bool Implanted { get; set; }

        public virtual BIAThreatEvent BIAThreatEvent { get; set; }
    }
}
