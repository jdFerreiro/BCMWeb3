using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class IncidentType : BaseEntity
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
