namespace BCMWeb.Core.Entities
{
    public class BIAServiceChain : BaseEntity
    {
        public long CompanyId { get; set; }
        public long ServiceChainId { get; set; }
        public string Description { get; set; }

        public virtual Company CompanyInfo { get; set; }
    }
}
