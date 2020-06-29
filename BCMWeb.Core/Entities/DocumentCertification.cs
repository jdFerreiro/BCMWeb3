using System;

namespace BCMWeb.Core.Entities
{
    public class DocumentCertification : BaseEntity
    {
        public long CompanyId { get; set; }
        public long DocumentId { get; set; }
        public long DocumentTypeId { get; set; }
        public long CertificationId { get; set; }
        public DateTime? CertificationDate { get; set; }
        public long? PersonId { get; set; }
        public bool Process { get; set; }
        public bool? Certificate { get; set; }

        public virtual Person PersonInfo { get; set; }
        public virtual Document DocumentInfo { get; set; }
    }
}
