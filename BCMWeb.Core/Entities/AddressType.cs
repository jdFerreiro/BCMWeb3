using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class AddressType : BaseEntity
    {
        public AddressType()
        {
            AddressTypeCultures = new HashSet<AddressTypeCulture>();
            AddressPersons = new HashSet<PersonAddress>();
        }

        public long AddressTypeId { get; set; }

        public virtual ICollection<AddressTypeCulture> AddressTypeCultures { get; set; }
        public virtual ICollection<PersonAddress> AddressPersons { get; set; }
    }
}
