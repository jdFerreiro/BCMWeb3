using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class Document : BaseEntity
    {
        public Document()
        {
            Audits = new HashSet<Audit>();
            BCPDocs = new HashSet<BCPDocument>();
            BIAThreats = new HashSet<BIAThreat>();
            BiaDocs = new HashSet<BIADocument>();
            BIAVIPPersons = new HashSet<BIAKeyPerson>();
            DocAttachments = new HashSet<DocumentAttachment>();
            DocumentAprovals = new HashSet<DocumentApproval>();
            DocumentCertifications = new HashSet<DocumentCertification>();
            DocumentContents = new HashSet<DocumentContent>();
            DocumentInterviews = new HashSet<DocumentInterview>();
            DocumentVIPPersons = new HashSet<DocumentKeyPerson>();
            PMTDocumentSchedules = new HashSet<PMTScheduleDocument>();
            PPEFrecuencies = new HashSet<PPEFrecuency>();
        }

        public long CompanyId { get; set; }
        public long DocumentId { get; set; }
        public long DocumentTypeId { get; set; }
        public long DocumentNumber { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public long DocumentStateId { get; set; }
        public DateTime DocumentStateDate { get; set; }
        public bool IsBussiness { get; set; }
        public int VersionNumber { get; set; }
        public int? OriginalVersion { get; set; }
        public long ResponsabilePersonId { get; set; }
        public bool CertificationRequired { get; set; }

        public virtual Company CompanyInfo { get; set; }
        public virtual DocumentState DocumentStateInfo { get; set; }
        public virtual ICollection<Audit> Audits { get; set; }
        public virtual ICollection<BCPDocument> BCPDocs { get; set; }
        public virtual ICollection<BIAThreat> BIAThreats { get; set; }
        public virtual ICollection<BIADocument> BiaDocs { get; set; }
        public virtual ICollection<BIAKeyPerson> BIAVIPPersons { get; set; }
        public virtual ICollection<DocumentAttachment> DocAttachments { get; set; }
        public virtual ICollection<DocumentApproval> DocumentAprovals { get; set; }
        public virtual ICollection<DocumentCertification> DocumentCertifications { get; set; }
        public virtual ICollection<DocumentContent> DocumentContents { get; set; }
        public virtual ICollection<DocumentInterview> DocumentInterviews { get; set; }
        public virtual ICollection<DocumentKeyPerson> DocumentVIPPersons { get; set; }
        public virtual ICollection<PMTScheduleDocument> PMTDocumentSchedules { get; set; }
        public virtual ICollection<PPEFrecuency> PPEFrecuencies { get; set; }
    }
}
