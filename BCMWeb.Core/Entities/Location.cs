namespace BCMWeb.Core.Entities
{
    public partial class Location
    {
        public long CompanyId { get; set; }
        public long LocationId { get; set; }
        public string LocationCode { get; set; }
        public string Name { get; set; }
        public long CountryId { get; set; }
        public long StateId { get; set; }
        public long CityId { get; set; }

        public virtual CountryState StateInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
        public virtual City CityInfo { get; set; }
        public virtual Country CountryInfo { get; set; }
    }
}
