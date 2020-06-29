using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class BIAWorkUnit : BaseEntity
    {
        public BIAWorkUnit()
        {
            WorkUnitProcesses = new HashSet<BIAWorkUnitProcess>();
        }

        public long CompanyId { get; set; }
        public long WorkUnitId { get; set; }
        public string Name { get; set; }
        public long OUId { get; set; }

        public virtual OrganizationUnit OUInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
        public virtual ICollection<BIAWorkUnitProcess> WorkUnitProcesses { get; set; }
    }
}
