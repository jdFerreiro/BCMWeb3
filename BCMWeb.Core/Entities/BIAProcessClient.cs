using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class BIAProcessClient : BaseEntity
    {
        public BIAProcessClient()
        {
            BIAWorkUnitPerson = new HashSet<BIAWorkUnitPerson>();
        }

        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public long ProcessClientId { get; set; }
        public string Unit { get; set; }
        public string Responsable { get; set; }
        public string Process { get; set; }
        public string Product { get; set; }

        public virtual BIAProcess BIAProcessInfo { get; set; }
        public virtual ICollection<BIAWorkUnitPerson> BIAWorkUnitPerson { get; set; }
    }
}
