namespace BCMWeb.Core.Entities
{
    public partial class BIAServiceChain
    {
        public long CompanyId { get; set; }
        public long ServiceChainId { get; set; }
        public string Description { get; set; }

        public virtual Company CompanyInfo { get; set; }
    }
}
