using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class IncidentType
    {
        public IncidentType()
        {
            IncidentTypeCultures = new HashSet<IncidentTypeCulture>();
            Incidents = new HashSet<Incident>();
        }

        public int IncidentTypeId { get; set; }

        public virtual ICollection<IncidentTypeCulture> IncidentTypeCultures { get; set; }
        public virtual ICollection<Incident> Incidents { get; set; }
    }
}
