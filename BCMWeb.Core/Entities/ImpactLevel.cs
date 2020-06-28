using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class ImpactLevel
    {
        public ImpactLevel()
        {
            ImpactLevelCultures = new HashSet<ImpactLevelCulture>();
        }

        public int ImpactLevelId { get; set; }

        public virtual ICollection<ImpactLevelCulture> ImpactLevelCultures { get; set; }
    }
}
