namespace BCMWeb.Core.Entities
{
    public class CompanyStateCulture : BaseEntity
    {
        public string Culture { get; set; }
        public long CompanyStateId { get; set; }
        public string Description { get; set; }

        public virtual CompanyState CompanyStateInfo { get; set; }
    }
}
