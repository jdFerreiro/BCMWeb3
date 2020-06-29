using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class DocumentInterview : BaseEntity
    {
        public DocumentInterview()
        {
            DocumentInterviewPersons = new HashSet<DocumentInterviewPerson>();
        }

        public long CompanyId { get; set; }
        public long DocumentId { get; set; }
        public long DocumentTypeId { get; set; }
        public long InterviewId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual Document DocumentInfo { get; set; }
        public virtual ICollection<DocumentInterviewPerson> DocumentInterviewPersons { get; set; }
    }
}
