using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class Scale : BaseEntity
    {
        public Scale()
        {
            BIAFinancialImpacts = new HashSet<BIAFiancialImpact>();
            BIAOperationalImpacts = new HashSet<BIAOperationalImpact>();
            BIAMTDs = new HashSet<BIAMTD>();
            BIARPOs = new HashSet<BIARPO>();
            BIARTOs = new HashSet<BIARTO>();
            BIAWRTs = new HashSet<BIAWRT>();
            Citricities = new HashSet<Criticality>();
        }

        public long CompanyId { get; set; }
        public long ScaleId { get; set; }
        public long ScaleTypeId { get; set; }
        public short Value { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ScalePosition { get; set; }

        public virtual ScaleType ScaleTypeInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
        public virtual ICollection<BIAFiancialImpact> BIAFinancialImpacts { get; set; }
        public virtual ICollection<BIAOperationalImpact> BIAOperationalImpacts { get; set; }
        public virtual ICollection<BIAMTD> BIAMTDs { get; set; }
        public virtual ICollection<BIARPO> BIARPOs { get; set; }
        public virtual ICollection<BIARTO> BIARTOs { get; set; }
        public virtual ICollection<BIAWRT> BIAWRTs { get; set; }
        public virtual ICollection<Criticality> Citricities { get; set; }
    }
}
