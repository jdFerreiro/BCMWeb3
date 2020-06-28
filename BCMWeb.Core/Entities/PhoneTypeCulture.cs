namespace BCMWeb.Core.Entities
{
    public partial class PhoneTypeCulture
    {
        public string Culture { get; set; }
        public long PhoneTypeId { get; set; }
        public string Description { get; set; }

        public virtual PhoneType PhoneTypeInfo { get; set; }
    }
}
