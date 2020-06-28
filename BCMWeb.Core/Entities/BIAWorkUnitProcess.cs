using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class BIAWorkUnitProcess
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

        public virtual TblBiaunidadTrabajo BIAWorkUnitInfo { get; set; }
        public virtual BIAProcess BIAProcessInfo { get; set; }
        public virtual ICollection<BIAWorkUnitPerson> BIAWorkUnitPersons { get; set; }
    }
}
