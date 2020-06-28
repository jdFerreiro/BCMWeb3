using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class Company
    {
        public Company()
        {
            Audits = new HashSet<Audit>();
            CriticalProcessAudit = new HashSet<AuditCriticalProcess>();
            BCPDocs = new HashSet<BCPDocument>();
            BIAServiceChains = new HashSet<BIAServiceChain>();
            BIADocs = new HashSet<BIADocument>();
            BIAWorkUnits = new HashSet<TblBiaunidadTrabajo>();
            EmployeePositions = new HashSet<Position>();
            Criticalitys = new HashSet<Criticality>();
            MobileDeviceConnectios = new HashSet<DeviceConnection>();
            DeviceConnections = new HashSet<DeviceConnection>();
            Docs = new HashSet<Document>();
            DocVIPPersons = new HashSet<DocumentKeyPerson>();
            CompanyMenuOptions = new HashSet<CompanyMenuOption>();
            CompanyUsers = new HashSet<UserCompany>();
            Scales = new HashSet<Scale>();
            EmailFormats = new HashSet<EmailFormat>();
            Incidents = new HashSet<Incident>();
            Initiatives = new HashSet<Intiative>();
            InitiativesAttachments = new HashSet<IniciativeAttach>();
            Locations = new HashSet<Location>();
            MenuOptions = new HashSet<MenuOption>();
            ModuleAttachments = new HashSet<MenuAttach>();
            UserLevelMenuOptions = new HashSet<MenuLevelUser>();
            PPETestExecutions = new HashSet<PPETestExecution>();
            PPETestExecutionExersices = new HashSet<PPETestExecutionExercise>();
            PPETestPlannings = new HashSet<PPETestSchedule>();
            Persons = new HashSet<Person>();
            WorkSchedules = new HashSet<WorkSchedule>();
            WorkScheduleActions = new HashSet<WorkScheduleAction>();
            PMTMessageUpdates = new HashSet<PMTMessageUpdate>();
            PMTSchedules = new HashSet<PMTSchedule>();
            PMTResponsibleUpdates = new HashSet<PMTUpdateResponsable>();
            RiskProbabilities = new HashSet<RiskProbability>();
            Products = new HashSet<Product>();
            Providers = new HashSet<Provider>();
            UOs = new HashSet<OrganizationUnit>();
            UserUOs = new HashSet<UserOrganizationUnit>();
            Vicepresidences = new HashSet<VicePresidency>();
        }

        public long CompanyId { get; set; }
        public string LegalName { get; set; }
        public string GovermentId { get; set; }
        public string Tradename { get; set; }
        public string AdministrativeAddress { get; set; }
        public long CompanyStateId { get; set; }
        public DateTime CompanyStateLastUpdate { get; set; }
        public string LogoUrl { get; set; }
        public DateTime StartDate { get; set; }
        public bool? CanCreateProcess { get; set; }
        public bool? CanCreateUO { get; set; }
        public bool? CanCreateWorkUnit { get; set; }
        public bool? CanCreateApps { get; set; }
        public bool? CanCreateDocs { get; set; }
        public long? CountryId { get; set; }
        public long? StateId { get; set; }
        public long? CityId { get; set; }

        public virtual CompanyState CompanyStateInfo { get; set; }
        public virtual CountryState StateInfo { get; set; }
        public virtual City CityInfo { get; set; }
        public virtual Country CountryInfo { get; set; }
        public virtual ICollection<Audit> Audits { get; set; }
        public virtual ICollection<AuditCriticalProcess> CriticalProcessAudit { get; set; }
        public virtual ICollection<BCPDocument> BCPDocs { get; set; }
        public virtual ICollection<BIAServiceChain> BIAServiceChains { get; set; }
        public virtual ICollection<BIADocument> BIADocs { get; set; }
        public virtual ICollection<TblBiaunidadTrabajo> BIAWorkUnits { get; set; }
        public virtual ICollection<Position> EmployeePositions { get; set; }
        public virtual ICollection<Criticality> Criticalitys { get; set; }
        public virtual ICollection<DeviceConnection> MobileDeviceConnectios { get; set; }
        public virtual ICollection<DeviceConnection> DeviceConnections { get; set; }
        public virtual ICollection<Document> Docs { get; set; }
        public virtual ICollection<DocumentKeyPerson> DocVIPPersons { get; set; }
        public virtual ICollection<CompanyMenuOption> CompanyMenuOptions { get; set; }
        public virtual ICollection<UserCompany> CompanyUsers { get; set; }
        public virtual ICollection<Scale> Scales { get; set; }
        public virtual ICollection<EmailFormat> EmailFormats { get; set; }
        public virtual ICollection<Incident> Incidents { get; set; }
        public virtual ICollection<Intiative> Initiatives { get; set; }
        public virtual ICollection<IniciativeAttach> InitiativesAttachments { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<MenuOption> MenuOptions { get; set; }
        public virtual ICollection<MenuAttach> ModuleAttachments { get; set; }
        public virtual ICollection<MenuLevelUser> UserLevelMenuOptions { get; set; }
        public virtual ICollection<PPETestExecution> PPETestExecutions { get; set; }
        public virtual ICollection<PPETestExecutionExercise> PPETestExecutionExersices { get; set; }
        public virtual ICollection<PPETestSchedule> PPETestPlannings { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
        public virtual ICollection<WorkSchedule> WorkSchedules { get; set; }
        public virtual ICollection<WorkScheduleAction> WorkScheduleActions { get; set; }
        public virtual ICollection<PMTMessageUpdate> PMTMessageUpdates { get; set; }
        public virtual ICollection<PMTSchedule> PMTSchedules { get; set; }
        public virtual ICollection<PMTUpdateResponsable> PMTResponsibleUpdates { get; set; }
        public virtual ICollection<RiskProbability> RiskProbabilities { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Provider> Providers { get; set; }
        public virtual ICollection<OrganizationUnit> UOs { get; set; }
        public virtual ICollection<UserOrganizationUnit> UserUOs { get; set; }
        public virtual ICollection<VicePresidency> Vicepresidences { get; set; }
    }
}
