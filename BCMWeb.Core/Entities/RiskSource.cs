using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class RiskSource
    {
        public RiskSource()
        {
            BIAThreats = new HashSet<BIAThreat>();
        }

        public long CompanyId { get; set; }
        public string SourceCode { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BIAThreat> BIAThreats { get; set; }
    }
}
