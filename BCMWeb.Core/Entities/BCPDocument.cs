using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class BCPDocument : BaseEntity
    {
        public BCPDocument()
        {
            BCPRestartVIPPersons = new HashSet<BCPResumptionVIPPerson>();
            BCPRestartTasks = new HashSet<BCPResumptionTask>();
            BCPRestartKeyPersons = new HashSet<BCPRecoveryKeyPerson>();
            BCPRestartResources = new HashSet<BCMRecoveryResource>();
            BCPAnswerActions = new HashSet<BCPAnswerAction>();
            BCPAnswerResources = new HashSet<BCPAnswerResource>();
            BCPRestoreKits = new HashSet<BCPResumptionKit>();
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
        public virtual ICollection<BCPResumptionVIPPerson> BCPRestartVIPPersons { get; set; }
        public virtual ICollection<BCPResumptionTask> BCPRestartTasks { get; set; }
        public virtual ICollection<BCPRecoveryKeyPerson> BCPRestartKeyPersons { get; set; }
        public virtual ICollection<BCMRecoveryResource> BCPRestartResources { get; set; }
        public virtual ICollection<BCPAnswerAction> BCPAnswerActions { get; set; }
        public virtual ICollection<BCPAnswerResource> BCPAnswerResources { get; set; }
        public virtual ICollection<BCPResumptionKit> BCPRestoreKits { get; set; }
        public virtual ICollection<BCPRestoreInfraestructure> BCPRestoreInfrastructures { get; set; }
        public virtual ICollection<BCPRestoreFurniture> BCPRestoreFurnitures { get; set; }
        public virtual ICollection<BCPRestoreOther> BCPRestoreOthers { get; set; }
    }
}
