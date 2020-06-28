namespace BCMWeb.Core.Entities
{
    public partial class TestResultTypeCulture
    {
        public string Culture { get; set; }
        public int TestResultTypeId { get; set; }
        public string Description { get; set; }

        public virtual TestResultType TestResultTypeInfo { get; set; }
    }
}
