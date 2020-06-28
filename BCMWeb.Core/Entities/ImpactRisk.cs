using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class ImpactRisk
    {
        public ImpactRisk()
        {
            BIAThreats = new HashSet<BIAThreat>();
        }

        public long CompanyId { get; set; }
        public short ImpactId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BIAThreat> BIAThreats { get; set; }
    }
}
