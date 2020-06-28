namespace BCMWeb.Core.Entities
{
    public partial class Product
    {
        public long CompanyId { get; set; }
        public long ProductId { get; set; }
        public string Name { get; set; }

        public virtual Company CompanyInfo { get; set; }
    }
}
