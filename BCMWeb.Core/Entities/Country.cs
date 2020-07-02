using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class Country : BaseEntity
    {
        public Country()
        {
            Cities = new HashSet<City>();
            CountryCultures = new HashSet<CountryCulture>();
            Companies = new HashSet<Company>();
            CountryStates = new HashSet<CountryState>();
            Locations = new HashSet<Location>();
            PersonAddresses = new HashSet<PersonAddress>();
            VicePresidencies = new HashSet<VicePresidency>();
        }

        public long CountryId { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<CountryCulture> CountryCultures { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<CountryState> CountryStates { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<PersonAddress> PersonAddresses { get; set; }
        public virtual ICollection<VicePresidency> VicePresidencies { get; set; }
    }
}
