using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class PMTUpdateResponsable : BaseEntity
    {
        public PMTUpdateResponsable()
        {
            PMTUpdateResponsableEmails = new HashSet<PMTUpdateResponsableEmail>();
        }

        public long CompanyId { get; set; }
        public long MenuItemId { get; set; }
        public long MessageId { get; set; }
        public long? DocumentId { get; set; }
        public short? NotificationTypeId { get; set; }

        public virtual MenuOption MenuOptionInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
        public virtual ICollection<PMTUpdateResponsableEmail> PMTUpdateResponsableEmails { get; set; }
    }
}
