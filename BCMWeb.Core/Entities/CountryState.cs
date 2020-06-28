using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class CountryState
    {
        public CountryState()
        {
            Cities = new HashSet<City>();
            CountryStateCultures = new HashSet<CountryStateCulture>();
            Companies = new HashSet<Company>();
            Locations = new HashSet<Location>();
            PersonAddresses = new HashSet<PersonAddress>();
        }

        public long CountryId { get; set; }
        public long CountryStateId { get; set; }

        public virtual Country CountryInfo { get; set; }
        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<CountryStateCulture> CountryStateCultures { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
    }
}
