namespace BCMWeb.Core.Entities
{
    public partial class AddressTypeCulture
    {
        public string Culture { get; set; }
        public long AddressTypeId { get; set; }
        public string Description { get; set; }

        public virtual AddressType AddressTypeInfo { get; set; }
    }
}
