using System;

namespace BCMWeb.Core.Entities
{
    public partial class Criticality
    {
        public DateTime ApplicationDate { get; set; }
        public long CompanyId { get; set; }
        public long EscaleTypeId { get; set; }
        public string ScaleDescription { get; set; }

        public virtual Scale ScaleInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
    }
}
