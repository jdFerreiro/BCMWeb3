namespace BCMWeb.Core.Entities
{
    public class DocumentStateCulture : BaseEntity
    {
        public string Culture { get; set; }
        public long DocumentStateId { get; set; }
        public string Description { get; set; }

        public virtual DocumentState DocumentStateInfo { get; set; }
    }
}
