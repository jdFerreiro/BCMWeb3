namespace BCMWeb.Core.Entities
{
    public partial class OriginIncidentCulture
    {
        public string Culture { get; set; }
        public int OriginIncidentId { get; set; }
        public string Description { get; set; }

        public virtual OriginIncident OriginIncidentInfo { get; set; }
    }
}
