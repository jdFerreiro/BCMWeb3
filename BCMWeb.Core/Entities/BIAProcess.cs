using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class BIAProcess
    {
        public BIAProcess()
        {
            BCPDocuments = new HashSet<BCPDocument>();
            BIAThreats = new HashSet<BIAThreat>();
            BIAApps = new HashSet<BIAApp>();
            BIAProcessClients = new HashSet<BIAProcessClient>();
            BIADocs = new HashSet<BIADocumentation>();
            BIAInputs = new HashSet<BIAInput>();
            BIABigImpacts = new HashSet<BIABigImpact>();
            BIAFinancialImpacts = new HashSet<BIAFiancialImpact>();
            BIAOperationalImpacts = new HashSet<BIAOperationalImpact>();
            BIAInterdependencies = new HashSet<BIAInterdependecy>();
            BIAMTDs = new HashSet<BIAMTD>();
            BIAVIPPersons = new HashSet<BIAKeyPerson>();
            BIAProcessBackupPersons = new HashSet<BIAProcessBackupPerson>();
            BIAAlternateProcesses = new HashSet<BIAAlternateProcess>();
            BIAProviders = new HashSet<BIAProvider>();
            BIAPrimaryBackups = new HashSet<BIAPrimaryBackup>();
            BIAScondaryBackups = new HashSet<BIASecondaryBackup>();
            BIARPOs = new HashSet<BIARPO>();
            BIARTOs = new HashSet<BIARTO>();
            BIAWorkUnitProcesses = new HashSet<BIAWorkUnitProcess>();
            BIAWRT = new HashSet<BIAWRT>();
        }

        public long CompanyId { get; set; }
        public long BIADocumentId { get; set; }
        public long ProcessId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ProcessNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? OUId { get; set; }
        public bool? IsCritical { get; set; }
        public long? ProcessStateId { get; set; }
        public DateTime? LastProcessStateDate { get; set; }

        public virtual BIADocument BIADocumentInfo { get; set; }
        public virtual ProcessState ProcessStateInfo { get; set; }
        public virtual OrganizationUnit OUInfo { get; set; }
        public virtual ICollection<BCPDocument> BCPDocuments { get; set; }
        public virtual ICollection<BIAThreat> BIAThreats { get; set; }
        public virtual ICollection<BIAApp> BIAApps { get; set; }
        public virtual ICollection<BIAProcessClient> BIAProcessClients { get; set; }
        public virtual ICollection<BIADocumentation> BIADocs { get; set; }
        public virtual ICollection<BIAInput> BIAInputs { get; set; }
        public virtual ICollection<BIABigImpact> BIABigImpacts { get; set; }
        public virtual ICollection<BIAFiancialImpact> BIAFinancialImpacts { get; set; }
        public virtual ICollection<BIAOperationalImpact> BIAOperationalImpacts { get; set; }
        public virtual ICollection<BIAInterdependecy> BIAInterdependencies { get; set; }
        public virtual ICollection<BIAMTD> BIAMTDs { get; set; }
        public virtual ICollection<BIAKeyPerson> BIAVIPPersons { get; set; }
        public virtual ICollection<BIAProcessBackupPerson> BIAProcessBackupPersons { get; set; }
        public virtual ICollection<BIAAlternateProcess> BIAAlternateProcesses { get; set; }
        public virtual ICollection<BIAProvider> BIAProviders { get; set; }
        public virtual ICollection<BIAPrimaryBackup> BIAPrimaryBackups { get; set; }
        public virtual ICollection<BIASecondaryBackup> BIAScondaryBackups { get; set; }
        public virtual ICollection<BIARPO> BIARPOs { get; set; }
        public virtual ICollection<BIARTO> BIARTOs { get; set; }
        public virtual ICollection<BIAWorkUnitProcess> BIAWorkUnitProcesses { get; set; }
        public virtual ICollection<BIAWRT> BIAWRT { get; set; }
    }
}
