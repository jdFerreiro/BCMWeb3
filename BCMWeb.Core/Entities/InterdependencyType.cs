using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class InterdependencyType
    {
        public InterdependencyType()
        {
            InterdependencyTypeCultures = new HashSet<InterdependencyTypeCulture>();
        }

        public int InterdependencyTypeId { get; set; }

        public virtual ICollection<InterdependencyTypeCulture> InterdependencyTypeCultures { get; set; }
    }
}
