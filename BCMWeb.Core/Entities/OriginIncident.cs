using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class OriginIncident
    {
        public OriginIncident()
        {
            OriginIncidentCultures = new HashSet<OriginIncidentCulture>();
            Incidents = new HashSet<Incident>();
        }

        public int OriginIncidentId { get; set; }

        public virtual ICollection<OriginIncidentCulture> OriginIncidentCultures { get; set; }
        public virtual ICollection<Incident> Incidents { get; set; }
    }
}
