namespace BCMWeb.Core.Entities
{
    public class ResultTypeCulture : BaseEntity
    {
        public string Culture { get; set; }
        public int ResultTypeId { get; set; }
        public string Description { get; set; }

        public virtual ResultType ResultTypeInfo { get; set; }
    }
}
