using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class DocumentKeyPerson
    {
        public DocumentKeyPerson()
        {
            BIAKeyPerson = new HashSet<BIAKeyPerson>();
        }

        public long CompanyId { get; set; }
        public long DocumentId { get; set; }
        public long DocumentTypeId { get; set; }
        public long PersonId { get; set; }
        public string Name { get; set; }
        public string GovermentId { get; set; }
        public string OfficePhoneNumber { get; set; }
        public string MobilePhoneNumber { get; set; }
        public string HomePhoneNumber { get; set; }
        public string Email { get; set; }
        public string HomeAddress { get; set; }
        public bool? IsChief { get; set; }

        public virtual Person PersonInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
        public virtual Document DocumentInfo { get; set; }
        public virtual ICollection<BIAKeyPerson> BIAKeyPerson { get; set; }
    }
}
