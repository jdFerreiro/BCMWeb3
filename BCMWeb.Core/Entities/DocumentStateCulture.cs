namespace BCMWeb.Core.Entities
{
    public partial class DocumentStateCulture
    {
        public string Culture { get; set; }
        public long DocumentStateId { get; set; }
        public string Description { get; set; }

        public virtual DocumentState DocumentStateInfo { get; set; }
    }
}
