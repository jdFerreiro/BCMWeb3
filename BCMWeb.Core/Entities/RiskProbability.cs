using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class RiskProbability : BaseEntity
    {
        public RiskProbability()
        {
            BIAThreats = new HashSet<BIAThreat>();
        }

        public long ComanyId { get; set; }
        public short ProbabilityId { get; set; }
        public string Name { get; set; }
        public string GraphicLabel { get; set; }

        public virtual Company CompanyInfo { get; set; }
        public virtual ICollection<BIAThreat> BIAThreats { get; set; }
    }
}
