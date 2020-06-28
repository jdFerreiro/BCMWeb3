namespace BCMWeb.Core.Entities
{
    public partial class InterdependencyTypeCulture
    {
        public string Culture { get; set; }
        public int InterdependencyTypeId { get; set; }
        public string Description { get; set; }

        public virtual InterdependencyType InterdependencyTypeInfo { get; set; }
    }
}
