namespace BCMWeb.Core.Entities
{
    public class InterdependencyTypeCulture : BaseEntity
    {
        public string Culture { get; set; }
        public int InterdependencyTypeId { get; set; }
        public string Description { get; set; }

        public virtual InterdependencyType InterdependencyTypeInfo { get; set; }
    }
}
