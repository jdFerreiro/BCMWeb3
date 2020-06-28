using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class EmailType
    {
        public EmailType()
        {
            EmailTypeCultures = new HashSet<EmailTypeCulture>();
            EmailPersons = new HashSet<PersonEmail>();
        }

        public long EmailTypeId { get; set; }

        public virtual ICollection<EmailTypeCulture> EmailTypeCultures { get; set; }
        public virtual ICollection<PersonEmail> EmailPersons { get; set; }
    }
}
