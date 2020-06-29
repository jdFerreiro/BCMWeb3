using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class BIAWorkUnitProcess : BaseEntity
    {
        public BIAWorkUnitProcess()
        {
            BIAWorkUnitPersons = new HashSet<BIAWorkUnitPerson>();
        }

        public long CompanyId { get; set; }
        public long WorkUnitId { get; set; }
        public long WorkUnitProcessId { get; set; }
        public string Name { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }

        public virtual BIAWorkUnit BIAWorkUnitInfo { get; set; }
        public virtual BIAProcess BIAProcessInfo { get; set; }
        public virtual ICollection<BIAWorkUnitPerson> BIAWorkUnitPersons { get; set; }
    }
}
