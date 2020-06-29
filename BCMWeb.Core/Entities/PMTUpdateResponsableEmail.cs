using System;

namespace BCMWeb.Core.Entities
{
    public class PMTUpdateResponsableEmail : BaseEntity
    {
        public long CompanyId { get; set; }
        public long MenuOptionId { get; set; }
        public long MessageId { get; set; }
        public long UserId { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual PMTUpdateResponsable PMTUpdateResponsableInfo { get; set; }
        public virtual User IdUsuarioNavigation { get; set; }
    }
}
