namespace BCMWeb.Core.Entities
{
    public class ImpactTypeCulture : BaseEntity
    {
        public string Culture { get; set; }
        public int ImpactTypeId { get; set; }
        public string Description { get; set; }

        public virtual ImpactType ImpactTypeInfo { get; set; }
    }
}
