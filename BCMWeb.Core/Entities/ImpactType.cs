using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class ImpactType : BaseEntity
    {
        public ImpactType()
        {
            ImpactTypeCultures = new HashSet<ImpactTypeCulture>();
        }

        public int ImpactTypeId { get; set; }

        public virtual ICollection<ImpactTypeCulture> ImpactTypeCultures { get; set; }
    }
}
