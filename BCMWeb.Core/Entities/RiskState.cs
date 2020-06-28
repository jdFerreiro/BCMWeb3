using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class RiskState
    {
        public RiskState()
        {
            BIAThreats = new HashSet<BIAThreat>();
        }

        public long CompanyId { get; set; }
        public short RiskStateId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public virtual ICollection<BIAThreat> BIAThreats { get; set; }
    }
}
