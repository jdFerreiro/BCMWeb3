using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class CompanyMenuOption
    {
        public CompanyMenuOption()
        {
            DeviceConsignment = new HashSet<DeviceConsignment>();
        }

        public long CompanyId { get; set; }
        public long MenuOptionId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual MenuOption MenuOpcionInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
        public virtual ICollection<DeviceConsignment> DeviceConsignment { get; set; }
    }
}
