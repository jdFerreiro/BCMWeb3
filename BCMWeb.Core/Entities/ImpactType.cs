using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class ImpactType
    {
        public ImpactType()
        {
            ImpactTypeCultures = new HashSet<ImpactTypeCulture>();
        }

        public int ImpactTypeId { get; set; }

        public virtual ICollection<ImpactTypeCulture> ImpactTypeCultures { get; set; }
    }
}
