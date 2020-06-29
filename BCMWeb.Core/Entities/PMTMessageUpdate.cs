using System;

namespace BCMWeb.Core.Entities
{
    public class PMTMessageUpdate : BaseEntity
    {
        public long CompanyId { get; set; }
        public long MessageId { get; set; }
        public long MenuOptionId { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime LastConsignmentDate { get; set; }

        public virtual MenuOption MenuOptionInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
    }
}
