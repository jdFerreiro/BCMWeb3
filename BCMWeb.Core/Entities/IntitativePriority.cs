using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class IntitativePriority : BaseEntity
    {
        public IntitativePriority()
        {
            Intiatives = new HashSet<Intiative>();
        }

        public long CompanyId { get; set; }
        public short PriorityId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Intiative> Intiatives { get; set; }
    }
}
