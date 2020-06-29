using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class BIAThreatEvent : BaseEntity
    {
        public BIAThreatEvent()
        {
            BIAControlEvents = new HashSet<BIAControlEvent>();
        }

        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public long ThreatId { get; set; }
        public long ThreatEventId { get; set; }
        public string Name { get; set; }
        public long RiskEventId { get; set; }

        public virtual ICollection<BIAControlEvent> BIAControlEvents { get; set; }
    }
}
