namespace BCMWeb.Core.Entities
{
    public class CityCulture : BaseEntity
    {
        public string Culture { get; set; }
        public long CountryId { get; set; }
        public long StateId { get; set; }
        public long CityId { get; set; }
        public string Name { get; set; }

        public virtual City CityInfo { get; set; }
    }
}
