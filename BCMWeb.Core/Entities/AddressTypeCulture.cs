namespace BCMWeb.Core.Entities
{
    public class AddressTypeCulture : BaseEntity
    {
        public string Culture { get; set; }
        public long AddressTypeId { get; set; }
        public string Description { get; set; }

        public virtual AddressType AddressTypeInfo { get; set; }
    }
}
