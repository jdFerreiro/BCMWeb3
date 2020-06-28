namespace BCMWeb.Core.Entities
{
    public partial class MonthCulture
    {
        public string Culture { get; set; }
        public int MonthId { get; set; }
        public string Description { get; set; }

        public virtual Month MonthInfo { get; set; }
    }
}
