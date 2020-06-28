using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class City
    {
        public City()
        {
            CityCultures = new HashSet<CityCulture>();
            Companies = new HashSet<Company>();
            Locations = new HashSet<Location>();
            PersonAddresses = new HashSet<PersonAddress>();
        }

        public long CountryId { get; set; }
        public long StateId { get; set; }
        public long CityId { get; set; }

        public virtual CountryState StateInfo { get; set; }
        public virtual Country CountryInfo { get; set; }
        public virtual ICollection<CityCulture> CityCultures { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
    }
}
