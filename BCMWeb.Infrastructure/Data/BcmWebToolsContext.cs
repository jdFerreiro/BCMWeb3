using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BCMWeb.Infrastructure.Data
{
    public partial class BcmWebToolsContext : DbContext
    {
        public BcmWebToolsContext()
        {
        }

        public BcmWebToolsContext(DbContextOptions<BcmWebToolsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<CriticalProcessAudit> CriticalProcessAudits { get; set; }
        public virtual DbSet<BCPDocument> BCPDocuments { get; set; }
        public virtual DbSet<BCPResumptionVIPPerson> BCPResumptionVIPPersons { get; set; }
        public virtual DbSet<BCPResumptionTask> BCPResumptionTasks { get; set; }
        public virtual DbSet<BCPResumptionTaskActivity> BCPResumptionTaskActivities { get; set; }
        public virtual DbSet<BCPRecoveryKeyPerson> BCPRecoveryKeyPersons { get; set; }
        public virtual DbSet<BCMRecoveryResource> BCMRecoveryResources { get; set; }
        public virtual DbSet<BCPAnswerAction> BCPAnswerActions { get; set; }
        public virtual DbSet<BCPAnswerResource> BCPAnswerResources { get; set; }
        public virtual DbSet<BCPResumptionKit> BCPResumptionKits { get; set; }
        public virtual DbSet<BCPRestoreInfraestructure> BCPRestoreInfraestructures { get; set; }
        public virtual DbSet<BCPRestoreFurniture> BCPRestoreFurnitures { get; set; }
        public virtual DbSet<BCPRestoreOther> BCPRestoreOthers { get; set; }
        public virtual DbSet<BIAThreat> BIAThreats { get; set; }
        public virtual DbSet<BIAThreatEvent> BIAThreatEvents { get; set; }
        public virtual DbSet<BIAApp> BIAApps { get; set; }
        public virtual DbSet<BIAServiceChain> BIAServiceChains { get; set; }
        public virtual DbSet<BIAProcessClient> BIAProcessClients { get; set; }
        public virtual DbSet<BIAComment> BIAComments { get; set; }
        public virtual DbSet<BIADocumentation> BIADocumentations { get; set; }
        public virtual DbSet<BIADocument> BIADocuments { get; set; }
        public virtual DbSet<BIAInput> BIAInputs { get; set; }
        public virtual DbSet<BIAControlEvent> BIAControlEvents { get; set; }
        public virtual DbSet<BIARiskEvent> BIARiskEvents { get; set; }
        public virtual DbSet<BIABigImpact> BIABigImpacts { get; set; }
        public virtual DbSet<BIAFiancialImpact> BIAFiancialImpacts { get; set; }
        public virtual DbSet<BIAOperationalImpact> BIAOperationalImpacts { get; set; }
        public virtual DbSet<BIAInterdependecy> BIAInterdependecies { get; set; }
        public virtual DbSet<BIAMTD> BIAMTDs { get; set; }
        public virtual DbSet<BIAKeyPerson> BIAKeyPersons { get; set; }
        public virtual DbSet<BIAProcessBackupPerson> BIAProcessBackupPersons { get; set; }
        public virtual DbSet<BIAProcess> BIAProcesses { get; set; }
        public virtual DbSet<BIAAlternateProcess> BIAAlternateProcesss { get; set; }
        public virtual DbSet<BIAProvider> BIAProviders { get; set; }
        public virtual DbSet<BIAPrimaryBackup> BIAPrimaryBackups { get; set; }
        public virtual DbSet<BIASecondaryBackup> BIASecondaryBackups { get; set; }
        public virtual DbSet<BIARPO> BIARPOs { get; set; }
        public virtual DbSet<BIARTO> BIARTOs { get; set; }
        public virtual DbSet<BIAWorkUnit> BIAWorkUnits { get; set; }
        public virtual DbSet<BIAWorkUnitPerson> BIAWorkUnitPersons { get; set; }
        public virtual DbSet<BIAWorkUnitProcess> BIAWorkUnitProcesses { get; set; }
        public virtual DbSet<BIAWRT> BIAWRTs { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<RiskControl> RiskControls { get; set; }
        public virtual DbSet<Criticality> Criticalities { get; set; }
        public virtual DbSet<CityCulture> CityCultures { get; set; }
        public virtual DbSet<CountryStateCulture> CountryStateCultures { get; set; }
        public virtual DbSet<DocumentStateCulture> DocumentStateCultures { get; set; }
        public virtual DbSet<CompanyStateCulture> CompanyStateCultures { get; set; }
        public virtual DbSet<ProcessStateCulture> ProcessStateCultures { get; set; }
        public virtual DbSet<UserSateCulture> UserSateCultures { get; set; }
        public virtual DbSet<MonthCulture> MonthCultures { get; set; }
        public virtual DbSet<ImpactLevelCulture> ImpactLevelCultures { get; set; }
        public virtual DbSet<CultureLevelUser> CultureLevelUsers { get; set; }
        public virtual DbSet<CountryCulture> CountryCultures { get; set; }
        public virtual DbSet<PPETestStatusCulture> PPETestStatusCultures { get; set; }
        public virtual DbSet<WorkScheduleStateCulture> WorkScheduleStateCultures { get; set; }
        public virtual DbSet<PMTScheduleUpdateTypeCulture> PMTScheduleUpdateTypeCultures { get; set; }
        public virtual DbSet<PMTScheduleNotificationTypeCulture> PMTScheduleNotificationTypeCultures { get; set; }
        public virtual DbSet<EmailTypeCulture> EmailTypeCultures { get; set; }
        public virtual DbSet<AddressTypeCulture> AddressTypeCultures { get; set; }
        public virtual DbSet<FrecuencyTypeCulture> FrecuencyTypeCultures { get; set; }
        public virtual DbSet<ImpactTypeCulture> ImpactTypeCultures { get; set; }
        public virtual DbSet<InterdependencyTypeCulture> InterdependencyTypeCultures { get; set; }
        public virtual DbSet<ResultTypeCulture> ResultTypeCultures { get; set; }
        public virtual DbSet<TestResultTypeCulture> TestResultTypeCultures { get; set; }
        public virtual DbSet<TableTypeContentCulture> TableTypeContentCultures { get; set; }
        public virtual DbSet<PhoneTypeCulture> PhoneTypeCultures { get; set; }
        public virtual DbSet<LocationTypeInformationCulture> LocationTypeInformationCultures { get; set; }
        public virtual DbSet<IncidentSourceCulture> IncidentSourceCultures { get; set; }
        public virtual DbSet<OriginIncidentCulture> OriginIncidentCultures { get; set; }
        public virtual DbSet<IncidentTypeCulture> IncidentTypeCultures { get; set; }
        public virtual DbSet<Device> Devices { get; set; }
        public virtual DbSet<DeviceConnection> DeviceConnections { get; set; }
        public virtual DbSet<DeviceConsignment> DeviceConsignments { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<DocumentAttachment> DocumentAttachments { get; set; }
        public virtual DbSet<DocumentApproval> DocumentApprovals { get; set; }
        public virtual DbSet<DocumentCertification> DocumentCertifications { get; set; }
        public virtual DbSet<DocumentContent> DocumentContents { get; set; }
        public virtual DbSet<DocumentInterview> DocumentInterviews { get; set; }
        public virtual DbSet<DocumentInterviewPerson> DocumentInterviewPersons { get; set; }
        public virtual DbSet<DocumentKeyPerson> DocumentKeyPersons { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyMenuOption> CompanyMenuOptions { get; set; }
        public virtual DbSet<UserCompany> UserCompanies { get; set; }
        public virtual DbSet<Scale> Scales { get; set; }
        public virtual DbSet<CountryState> CountryStates { get; set; }
        public virtual DbSet<DocumentState> DocumentStates { get; set; }
        public virtual DbSet<CompanyState> CompanyStates { get; set; }
        public virtual DbSet<ProcessState> ProcessStates { get; set; }
        public virtual DbSet<RiskState> RiskStates { get; set; }
        public virtual DbSet<UserState> UserStates { get; set; }
        public virtual DbSet<EmailFormat> EmailFormats { get; set; }
        public virtual DbSet<IncidentSource> IncidentSources { get; set; }
        public virtual DbSet<RiskSource> RiskSources { get; set; }
        public virtual DbSet<ImpactRisk> ImpactRisks { get; set; }
        public virtual DbSet<Incident> Incidents { get; set; }
        public virtual DbSet<IntitativePriority> IntitativePrioritiesys { get; set; }
        public virtual DbSet<Intiative> Intiatives { get; set; }
        public virtual DbSet<IniciativeAttach> IniciativeAttachs { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Month> Months { get; set; }
        public virtual DbSet<MenuOption> MenuOptions { get; set; }
        public virtual DbSet<MenuAttach> MenuAttachs { get; set; }
        public virtual DbSet<MenuLevelUser> MenuLevelUsers { get; set; }
        public virtual DbSet<UserMenuOption> UserMenuOptions { get; set; }
        public virtual DbSet<OriginIncident> OriginIncidents { get; set; }
        public virtual DbSet<ImpactLevel> ImpactLevels { get; set; }
        public virtual DbSet<UserLevel> UserLevels { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<PPETestExecution> PPETestExecutions { get; set; }
        public virtual DbSet<PPETestExecutionExercise> PPETestExecutionExercises { get; set; }
        public virtual DbSet<PPETestExecutionExerciseParticipant> PPETestExecutionExerciseParticipants { get; set; }
        public virtual DbSet<PPETestExecutionExerciseResource> PPETestExecutionExerciseResources { get; set; }
        public virtual DbSet<PPETestExecutionParticipant> PPETestExecutionParticipants { get; set; }
        public virtual DbSet<PPETestExecutionResult> PPETestExecutionResults { get; set; }
        public virtual DbSet<PPETestStatus> PPETestStatuses { get; set; }
        public virtual DbSet<PPETestSchedule> PPETestSchedules { get; set; }
        public virtual DbSet<PPETestScheduleExercise> PPETestScheduleExercises { get; set; }
        public virtual DbSet<PPETestScheduleExerciseParticipant> PPETestScheduleExerciseParticipants { get; set; }
        public virtual DbSet<PPETestScheduleExerciseResource> PPETestScheduleExerciseResources { get; set; }
        public virtual DbSet<PPETestScheduleParticipant> PPETestScheduleParticipants { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<PersonEmail> PersonEmails { get; set; }
        public virtual DbSet<PersonAddress> PersonAddresses { get; set; }
        public virtual DbSet<PersonPhone> PersonPhones { get; set; }
        public virtual DbSet<WorkSchedule> WorkSchedules { get; set; }
        public virtual DbSet<WorkScheduleAction> WorkScheduleActions { get; set; }
        public virtual DbSet<WorkScheduleAudit> WorkScheduleAudits { get; set; }
        public virtual DbSet<WorkScheduleState> WorkScheduleStates { get; set; }
        public virtual DbSet<PMTMessageUpdate> PMTMessageUpdates { get; set; }
        public virtual DbSet<PMTSchedule> PMTSchedules { get; set; }
        public virtual DbSet<PMTScheduleDocument> PMTScheduleDocuments { get; set; }
        public virtual DbSet<PMTScheduleUpdateType> PMTScheduleUpdateTypes { get; set; }
        public virtual DbSet<PMTScheduleNotificationType> PMTScheduleNotificationTypes { get; set; }
        public virtual DbSet<PMTScheduleUser> PMTScheduleUsers { get; set; }
        public virtual DbSet<PMTUpdateResponsable> PMTUpdateResponsables { get; set; }
        public virtual DbSet<PMTUpdateResponsableEmail> PMTUpdateResponsableEmails { get; set; }
        public virtual DbSet<PPEFrecuency> PPEFrecuencies { get; set; }
        public virtual DbSet<RiskProbability> RiskProbabilities { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<RiskSeverity> RiskSeverities { get; set; }
        public virtual DbSet<EmailType> EmailTypes { get; set; }
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<ScaleType> ScaleTypes { get; set; }
        public virtual DbSet<FrecuencyType> FrecuencyTypes { get; set; }
        public virtual DbSet<ImpactType> ImpactTypes { get; set; }
        public virtual DbSet<IncidentType> IncidentTypes { get; set; }
        public virtual DbSet<InterdependencyType> InterdependencyTypes { get; set; }
        public virtual DbSet<ResultType> ResultTypes { get; set; }
        public virtual DbSet<TestResultType> TestResultTypes { get; set; }
        public virtual DbSet<TableTypeContent> TableTypeContents { get; set; }
        public virtual DbSet<PhoneType> PhoneTypes { get; set; }
        public virtual DbSet<LocationTypeInformation> LocationTypeInformations { get; set; }
        public virtual DbSet<OrganizationUnit> OrganizationUnits { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserOrganizationUnit> UserOrganizationUnits { get; set; }
        public virtual DbSet<VicePresidency> VicePresidenciess { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
