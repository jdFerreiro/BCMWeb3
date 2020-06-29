namespace BCMWeb.Core.Entities
{
    public class PersonAddress : BaseEntity
    {
        public long CompanyId { get; set; }
        public long PersonId { get; set; }
        public long PersonAddressId { get; set; }
        public long AddressTypeId { get; set; }
        public string LocationName { get; set; }
        public long CountryId { get; set; }
        public long StateId { get; set; }
        public long CityId { get; set; }

        public virtual Person PersonInfo { get; set; }
        public virtual City CityInfo { get; set; }
        public virtual CountryState StateInfo { get; set; }
        public virtual Country CountryInfo { get; set; }
        public virtual AddressType AddressTypeInfo { get; set; }
    }
}
