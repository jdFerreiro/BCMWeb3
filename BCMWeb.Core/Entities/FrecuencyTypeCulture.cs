namespace BCMWeb.Core.Entities
{
    public class FrecuencyTypeCulture : BaseEntity
    {
        public string Culture { get; set; }
        public long FrecuencyTypeId { get; set; }
        public string Description { get; set; }

        public virtual FrecuencyType FrecuencyTypeInfo { get; set; }
    }
}
