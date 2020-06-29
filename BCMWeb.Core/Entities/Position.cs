using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class Position : BaseEntity
    {
        public Position()
        {
            Persons = new HashSet<Person>();
        }

        public long CompanyId { get; set; }
        public long PositionId { get; set; }
        public string Description { get; set; }

        public virtual Company CompanyInfo { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
    }
}
