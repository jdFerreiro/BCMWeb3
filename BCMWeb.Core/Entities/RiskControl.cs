using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class RiskControl
    {
        public RiskControl()
        {
            BIAThreats = new HashSet<BIAThreat>();
        }

        public long CompanyId { get; set; }
        public short ControlId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BIAThreat> BIAThreats { get; set; }
    }
}
