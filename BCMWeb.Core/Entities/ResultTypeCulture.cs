namespace BCMWeb.Core.Entities
{
    public partial class ResultTypeCulture
    {
        public string Culture { get; set; }
        public int ResultTypeId { get; set; }
        public string Description { get; set; }

        public virtual ResultType ResultTypeInfo { get; set; }
    }
}
