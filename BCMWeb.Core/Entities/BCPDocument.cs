using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class BCPDocument
    {
        public BCPDocument()
        {
            BCPRestartVIPPersons = new HashSet<BCPRestartVIPPerson>();
            BCPRestartTasks = new HashSet<BCPRestoreTask>();
            BCPRestartKeyPersons = new HashSet<BCPRestoreKeyPerson>();
            BCPRestartResources = new HashSet<BCMRecoverResource>();
            BCPAnswerActions = new HashSet<BCPRestoreAction>();
            BCPAnswerResources = new HashSet<BCPAnswerResource>();
            BCPRestoreKits = new HashSet<BCPRestoreKit>();
            BCPRestoreInfrastructures = new HashSet<BCPRestoreInfraestructure>();
            BCPRestoreFurnitures = new HashSet<BCPRestoreFurniture>();
            BCPRestoreOthers = new HashSet<BCPRestoreOther>();
        }

        public long CompanyId { get; set; }
        public long BCPDocumentId { get; set; }
        public long? DocumentId { get; set; }
        public long? DocumentTypeId { get; set; }
        public long? BIADocumentId { get; set; }
        public long? ProcessId { get; set; }
        public long? OUId { get; set; }
        public string ProcessName { get; set; }
        public string SubprocessName { get; set; }
        public string ResponsabileName { get; set; }

        public virtual Document DocumentInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
        public virtual BIAProcess BIAProcessInfo { get; set; }
        public virtual ICollection<BCPRestartVIPPerson> BCPRestartVIPPersons { get; set; }
        public virtual ICollection<BCPRestoreTask> BCPRestartTasks { get; set; }
        public virtual ICollection<BCPRestoreKeyPerson> BCPRestartKeyPersons { get; set; }
        public virtual ICollection<BCMRecoverResource> BCPRestartResources { get; set; }
        public virtual ICollection<BCPRestoreAction> BCPAnswerActions { get; set; }
        public virtual ICollection<BCPAnswerResource> BCPAnswerResources { get; set; }
        public virtual ICollection<BCPRestoreKit> BCPRestoreKits { get; set; }
        public virtual ICollection<BCPRestoreInfraestructure> BCPRestoreInfrastructures { get; set; }
        public virtual ICollection<BCPRestoreFurniture> BCPRestoreFurnitures { get; set; }
        public virtual ICollection<BCPRestoreOther> BCPRestoreOthers { get; set; }
    }
}
