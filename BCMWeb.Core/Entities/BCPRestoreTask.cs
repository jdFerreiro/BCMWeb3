using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class BCPRestoreTask
    {
        public BCPRestoreTask()
        {
            BCPRestoreTaskActivities = new HashSet<BCPRestoreTaskActivity>();
        }

        public long CompanyId { get; set; }
        public long BCPDocumentId { get; set; }
        public long BCPRestoreTaskId { get; set; }
        public string Name { get; set; }

        public virtual BCPDocument BCPDocument { get; set; }
        public virtual ICollection<BCPRestoreTaskActivity> BCPRestoreTaskActivities { get; set; }
    }
}
