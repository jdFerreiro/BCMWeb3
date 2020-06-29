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
            TblLocalidad = new HashSet<Location>();
            TblPersonaDireccion = new HashSet<PersonAddress>();
            TblVicepresidencia = new HashSet<VicePresidency>();
        }

        public long CountryId { get; set; }

        public virtual ICollection<City> Cities { get; set; }
        public virtual ICollection<CountryCulture> CountryCultures { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<CountryState> CountryStates { get; set; }
        public virtual ICollection<Location> TblLocalidad { get; set; }
        public virtual ICollection<PersonAddress> TblPersonaDireccion { get; set; }
        public virtual ICollection<VicePresidency> TblVicepresidencia { get; set; }
    }
}
