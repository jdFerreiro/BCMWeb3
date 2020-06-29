namespace BCMWeb.Core.Entities
{
    public class IncidentSourceCulture : BaseEntity
    {
        public string Culture { get; set; }
        public int IncidentSourceId { get; set; }
        public string Description { get; set; }

        public virtual IncidentSource IncidentSourceInfo { get; set; }
    }
}
