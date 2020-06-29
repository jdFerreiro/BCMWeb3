namespace BCMWeb.Core.Entities
{
    public class ImpactLevelCulture : BaseEntity
    {
        public string Culture { get; set; }
        public int ImpactLevelId { get; set; }
        public string Description { get; set; }

        public virtual ImpactLevel ImpactLevelInfo { get; set; }
    }
}
