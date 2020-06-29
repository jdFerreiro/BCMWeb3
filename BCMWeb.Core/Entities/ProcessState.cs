using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class ProcessState : BaseEntity
    {
        public ProcessState()
        {
            BIAProcesses = new HashSet<BIAProcess>();
            BIAProcessStateCultures = new HashSet<ProcessStateCulture>();
        }

        public long ProcessStateId { get; set; }

        public virtual ICollection<BIAProcess> BIAProcesses { get; set; }
        public virtual ICollection<ProcessStateCulture> BIAProcessStateCultures { get; set; }
    }
}
