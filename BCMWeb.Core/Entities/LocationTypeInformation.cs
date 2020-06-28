using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class LocationTypeInformation
    {
        public LocationTypeInformation()
        {
            LocationTypeInformationCultures = new HashSet<LocationTypeInformationCulture>();
        }

        public int LocationTypeInformationId { get; set; }

        public virtual ICollection<LocationTypeInformationCulture> LocationTypeInformationCultures { get; set; }
    }
}
