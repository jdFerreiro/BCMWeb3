using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class PhoneType
    {
        public PhoneType()
        {
            PhoneTypeCultures = new HashSet<PhoneTypeCulture>();
            PhonePersons = new HashSet<PersonPhone>();
        }

        public long PhoneTypeId { get; set; }

        public virtual ICollection<PhoneTypeCulture> PhoneTypeCultures { get; set; }
        public virtual ICollection<PersonPhone> PhonePersons { get; set; }
    }
}
