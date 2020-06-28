using System;

namespace BCMWeb.Core.Entities
{
    public partial class Incident
    {
        public long CompanyId { get; set; }
        public long IncidentId { get; set; }
        public int? IncidentType { get; set; }
        public int? OriginIncidentId { get; set; }
        public int? SourceIncidentId { get; set; }
        public DateTime? IncidentDate { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int? Duration { get; set; }
        public string ReporterName { get; set; }
        public string SolverName { get; set; }
        public string Comments { get; set; }

        public virtual Company CompanyInfo { get; set; }
        public virtual IncidentSource IncidentSourceInfo { get; set; }
        public virtual OriginIncident OriginIncidentInfo { get; set; }
        public virtual IncidentType IncidentTypeInfo { get; set; }
    }
}
