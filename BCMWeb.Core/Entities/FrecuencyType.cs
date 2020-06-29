using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class FrecuencyType : BaseEntity
    {
        public FrecuencyType()
        {
            BIAFinancialImpacts = new HashSet<BIAFiancialImpact>();
            BIAOperationalImpacts = new HashSet<BIAOperationalImpact>();
            BIAMTDs = new HashSet<BIAMTD>();
            BIARPOs = new HashSet<BIARPO>();
            BIARTOs = new HashSet<BIARTO>();
            BIAWRTs = new HashSet<BIAWRT>();
            FrecuencyTypeCultures = new HashSet<FrecuencyTypeCulture>();
            PMTSchedules = new HashSet<PMTSchedule>();
            PPEFrecuencies = new HashSet<PPEFrecuency>();
        }

        public long FrecuencyTypeId { get; set; }

        public virtual ICollection<BIAFiancialImpact> BIAFinancialImpacts { get; set; }
        public virtual ICollection<BIAOperationalImpact> BIAOperationalImpacts { get; set; }
        public virtual ICollection<BIAMTD> BIAMTDs { get; set; }
        public virtual ICollection<BIARPO> BIARPOs { get; set; }
        public virtual ICollection<BIARTO> BIARTOs { get; set; }
        public virtual ICollection<BIAWRT> BIAWRTs { get; set; }
        public virtual ICollection<FrecuencyTypeCulture> FrecuencyTypeCultures { get; set; }
        public virtual ICollection<PMTSchedule> PMTSchedules { get; set; }
        public virtual ICollection<PPEFrecuency> PPEFrecuencies { get; set; }
    }
}
