using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class CompanyState
    {
        public CompanyState()
        {
            CompanyStateCultures = new HashSet<CompanyStateCulture>();
            Companies = new HashSet<Company>();
        }

        public long CompanyStateId { get; set; }

        public virtual ICollection<CompanyStateCulture> CompanyStateCultures { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}
