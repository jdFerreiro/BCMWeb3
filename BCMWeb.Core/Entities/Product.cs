namespace BCMWeb.Core.Entities
{
    public class Product : BaseEntity
    {
        public long CompanyId { get; set; }
        public long ProductId { get; set; }
        public string Name { get; set; }

        public virtual Company CompanyInfo { get; set; }
    }
}
