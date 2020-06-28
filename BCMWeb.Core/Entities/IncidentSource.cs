using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class IncidentSource
    {
        public IncidentSource()
        {
            IncidentSourceCultures = new HashSet<IncidentSourceCulture>();
            Incidents = new HashSet<Incident>();
        }

        public int IncidentSourceId { get; set; }

        public virtual ICollection<IncidentSourceCulture> IncidentSourceCultures { get; set; }
        public virtual ICollection<Incident> Incidents { get; set; }
    }
}
