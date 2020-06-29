using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class BCPResumptionTask : BaseEntity
    {
        public BCPResumptionTask()
        {
            BCPResumptionTaskActivities = new HashSet<BCPResumptionTaskActivity>();
        }

        public long CompanyId { get; set; }
        public long BCPDocumentId { get; set; }
        public long BCPResumptionTaskId { get; set; }
        public string Name { get; set; }

        public virtual BCPDocument BCPDocument { get; set; }
        public virtual ICollection<BCPResumptionTaskActivity> BCPResumptionTaskActivities { get; set; }
    }
}
