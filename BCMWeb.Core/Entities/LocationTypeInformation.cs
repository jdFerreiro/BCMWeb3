using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class LocationTypeInformation : BaseEntity
    {
        public LocationTypeInformation()
        {
            LocationTypeInformationCultures = new HashSet<LocationTypeInformationCulture>();
        }

        public int LocationTypeInformationId { get; set; }

        public virtual ICollection<LocationTypeInformationCulture> LocationTypeInformationCultures { get; set; }
    }
}
