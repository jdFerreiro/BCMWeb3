using System;

namespace BCMWeb.Core.Entities
{
    public class Criticality : BaseEntity
    {
        public DateTime ApplicationDate { get; set; }
        public long CompanyId { get; set; }
        public long EscaleTypeId { get; set; }
        public string ScaleDescription { get; set; }

        public virtual Scale ScaleInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
    }
}
