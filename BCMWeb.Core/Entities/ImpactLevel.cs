using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class ImpactLevel : BaseEntity
    {
        public ImpactLevel()
        {
            ImpactLevelCultures = new HashSet<ImpactLevelCulture>();
        }

        public int ImpactLevelId { get; set; }

        public virtual ICollection<ImpactLevelCulture> ImpactLevelCultures { get; set; }
    }
}
