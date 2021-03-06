﻿using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class RiskSeverity : BaseEntity
    {
        public RiskSeverity()
        {
            BIAThreats = new HashSet<BIAThreat>();
        }

        public long CompanyId { get; set; }
        public short SeveriryId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BIAThreat> BIAThreats { get; set; }
    }
}
