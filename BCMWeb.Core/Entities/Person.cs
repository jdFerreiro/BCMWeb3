using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class Person
    {
        public Person()
        {
            BPERestartVIPPersons = new HashSet<BCPRestartVIPPerson>();
            BCPRecoverVIPPersons = new HashSet<BCPRestoreKeyPerson>();
            BIABackupProcessPersons = new HashSet<BIAProcessBackupPerson>();
            DocApprovals = new HashSet<DocumentApproval>();
            DocsCertifications = new HashSet<DocumentCertification>();
            DocVIPPersons = new HashSet<DocumentKeyPerson>();
            PersonEmails = new HashSet<PersonEmail>();
            PersonAddress = new HashSet<PersonAddress>();
            PersonPhones = new HashSet<PersonPhone>();
        }

        public long CompanyId { get; set; }
        public long PersonId { get; set; }
        public string Name { get; set; }
        public string DocumentIdentificationId { get; set; }
        public long? OUId { get; set; }
        public long? PositionId { get; set; }
        public long? UserId { get; set; }

        public virtual Position PositionInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
        public virtual OrganizationUnit OUInfo { get; set; }
        public virtual User UserInfo { get; set; }
        public virtual ICollection<BCPRestartVIPPerson> BPERestartVIPPersons { get; set; }
        public virtual ICollection<BCPRestoreKeyPerson> BCPRecoverVIPPersons { get; set; }
        public virtual ICollection<BIAProcessBackupPerson> BIABackupProcessPersons { get; set; }
        public virtual ICollection<DocumentApproval> DocApprovals { get; set; }
        public virtual ICollection<DocumentCertification> DocsCertifications { get; set; }
        public virtual ICollection<DocumentKeyPerson> DocVIPPersons { get; set; }
        public virtual ICollection<PersonEmail> PersonEmails { get; set; }
        public virtual ICollection<PersonAddress> PersonAddress { get; set; }
        public virtual ICollection<PersonPhone> PersonPhones { get; set; }
    }
}
