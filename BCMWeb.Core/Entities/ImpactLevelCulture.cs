namespace BCMWeb.Core.Entities
{
    public partial class ImpactLevelCulture
    {
        public string Culture { get; set; }
        public int ImpactLevelId { get; set; }
        public string Description { get; set; }

        public virtual ImpactLevel ImpactLevelInfo { get; set; }
    }
}
