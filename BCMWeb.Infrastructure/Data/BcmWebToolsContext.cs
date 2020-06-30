using BCMWeb.Core.Entities;
using BCMWeb.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;

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
            modelBuilder.ApplyConfiguration(new AuditConfiguration());
            modelBuilder.ApplyConfiguration(new CriticalProcessAuditConfiguration());
            modelBuilder.ApplyConfiguration(new BCPDocumentConfiguration());
            modelBuilder.ApplyConfiguration(new BCPResumptionVIPPersonConfiguration());
            modelBuilder.ApplyConfiguration(new BCPResumptionTaskConfiguration());
            modelBuilder.ApplyConfiguration(new BCPResumptionTaskActivityConfiguration());
            modelBuilder.ApplyConfiguration(new BCPRecoveryKeyPersonConfiguration());
            modelBuilder.ApplyConfiguration(new BCMRecoveryResourceConfiguration());
            modelBuilder.ApplyConfiguration(new BCPAnswerActionConfiguration());
            modelBuilder.ApplyConfiguration(new BCPAnswerResourceConfiguration());
            modelBuilder.ApplyConfiguration(new BCPResumptionKitConfiguration());
            modelBuilder.ApplyConfiguration(new BCPRestoreInfraestructureConfiguration());
            modelBuilder.ApplyConfiguration(new BCPRestoreFurnitureConfiguration());
            modelBuilder.ApplyConfiguration(new BCPRestoreOtherConfiguration());
            modelBuilder.ApplyConfiguration(new BIAThreatConfiguration());
            modelBuilder.ApplyConfiguration(new BIAThreatEventConfiguration());
            modelBuilder.ApplyConfiguration(new BIAAppConfiguration());
            modelBuilder.ApplyConfiguration(new BIAServiceChainConfiguration());
            modelBuilder.ApplyConfiguration(new BIAProcessClientConfiguration());
            modelBuilder.ApplyConfiguration(new BIACommentConfiguration());
            modelBuilder.ApplyConfiguration(new BIADocumentationConfiguration());
            modelBuilder.ApplyConfiguration(new BIADocumentConfiguration());
            modelBuilder.ApplyConfiguration(new BIAInputConfiguration());
            modelBuilder.ApplyConfiguration(new BIAControlEventConfiguration());
            modelBuilder.ApplyConfiguration(new BIARiskEventConfiguration());
            modelBuilder.ApplyConfiguration(new BIABigImpactConfiguration());
            modelBuilder.ApplyConfiguration(new BIAFiancialImpactConfiguration());
            modelBuilder.ApplyConfiguration(new BIAOperationaImpactConfiguration());
            modelBuilder.ApplyConfiguration(new BIAInterdependecyConfiguration());
            modelBuilder.ApplyConfiguration(new BIAMTDConfiguration());
            modelBuilder.ApplyConfiguration(new BIAKeyPersonConfiguration());
            modelBuilder.ApplyConfiguration(new BIAProcessBackupPersonConfiguration());

            modelBuilder.Entity<BIAProcess>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId });

                entity.ToTable("tblBIAProceso");

                entity.HasIndex(e => e.ProcessStateId)
                    .HasName("IX_FK_tblBIAProceso_tblEstadoProceso");

                entity.HasIndex(e => new { e.CompanyId, e.OUId })
                    .HasName("IX_FK_tblBIAProceso_tblUnidadOrganizativa");

                entity.Property(e => e.ProcessId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastProcessStateDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(1500);

                entity.HasOne(d => d.ProcessStateInfo)
                    .WithMany(p => p.BIAProcesses)
                    .HasForeignKey(d => d.ProcessStateId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tblBIAProceso_tblEstadoProceso");

                entity.HasOne(d => d.BIADocumentInfo)
                    .WithMany(p => p.BIAProcesses)
                    .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId })
                    .HasConstraintName("FK_tblBIAProceso_tblBIADocumento");

                entity.HasOne(d => d.OUInfo)
                    .WithMany(p => p.BIAProcesses)
                    .HasForeignKey(d => new { d.CompanyId, d.OUId })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tblBIAProceso_tblUnidadOrganizativa");
            });

            modelBuilder.Entity<BIAAlternateProcess>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.AlternateProcessId });

                entity.ToTable("tblBIAProcesoAlterno");

                entity.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.AlternateProcessId).ValueGeneratedOnAdd();

                entity.Property(e => e.AlternateProcess).IsRequired();

                entity.HasOne(d => d.BIAProcessInfo)
                    .WithMany(p => p.BIAAlternateProcesses)
                    .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                    .HasConstraintName("FK_tblBIAProcesoAlterno_tblBIAProceso");
            });

            modelBuilder.Entity<BIAProvider>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.ProviderId });

                entity.ToTable("tblBIAProveedor");

                entity.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.ProviderId).ValueGeneratedOnAdd();

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Organization)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Service)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.BIAProcessInfo)
                    .WithMany(p => p.BIAProviders)
                    .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                    .HasConstraintName("FK_tblBIAProveedor_tblBIAProceso");
            });

            modelBuilder.Entity<BIAPrimaryBackup>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.BackupId });

                entity.ToTable("tblBIARespaldoPrimario");

                entity.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.BackupId).ValueGeneratedOnAdd();

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.BIAProcessInfo)
                    .WithMany(p => p.BIAPrimaryBackups)
                    .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                    .HasConstraintName("FK_tblBIARespaldoPrimario_tblBIAProceso");
            });

            modelBuilder.Entity<BIASecondaryBackup>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BIAocumentId, e.ProcessId, e.BackupId });

                entity.ToTable("tblBIARespaldoSecundario");

                entity.Property(e => e.BIAocumentId).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.BackupId).ValueGeneratedOnAdd();

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.BIAProcessInfo)
                    .WithMany(p => p.BIAScondaryBackups)
                    .HasForeignKey(d => new { d.CompanyId, d.BIAocumentId, d.ProcessId })
                    .HasConstraintName("FK_tblBIARespaldoSecundario_tblBIAProceso");
            });

            modelBuilder.Entity<BIARPO>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.RPOId });

                entity.ToTable("tblBIARPO");

                entity.HasIndex(e => e.FrecuencyTypeId)
                    .HasName("IX_FK_tblBIARPO_tblTipoFrecuencia");

                entity.HasIndex(e => new { e.CompanyId, e.ScaleId })
                    .HasName("IX_FK_tblBIARPO_tblEscala");

                entity.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.RPOId)
                    .HasColumnName("IdRPO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.FrecuencyTypeInfo)
                    .WithMany(p => p.BIARPOs)
                    .HasForeignKey(d => d.FrecuencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIARPO_tblTipoFrecuencia");

                entity.HasOne(d => d.ScaleInfo)
                    .WithMany(p => p.BIARPOs)
                    .HasForeignKey(d => new { d.CompanyId, d.ScaleId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIARPO_tblEscala");

                entity.HasOne(d => d.BIAProcessInfo)
                    .WithMany(p => p.BIARPOs)
                    .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                    .HasConstraintName("FK_tblBIARPO_tblBIAProceso");
            });

            modelBuilder.Entity<BIARTO>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BIADocument, e.ProcessId, e.RTOId });

                entity.ToTable("tblBIARTO");

                entity.HasIndex(e => e.FrecuencyTypeId)
                    .HasName("IX_FK_tblBIARTO_tblTipoFrecuencia");

                entity.HasIndex(e => new { e.CompanyId, e.ScaleId })
                    .HasName("IX_FK_tblBIARTO_tblEscala");

                entity.Property(e => e.BIADocument).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.RTOId)
                    .HasColumnName("IdRTO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Comments).IsRequired();

                entity.HasOne(d => d.FrecuencyTypeInfo)
                    .WithMany(p => p.BIARTOs)
                    .HasForeignKey(d => d.FrecuencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIARTO_tblTipoFrecuencia");

                entity.HasOne(d => d.ScaleInfo)
                    .WithMany(p => p.BIARTOs)
                    .HasForeignKey(d => new { d.CompanyId, d.ScaleId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIARTO_tblEscala");

                entity.HasOne(d => d.BIAProcessInfo)
                    .WithMany(p => p.BIARTOs)
                    .HasForeignKey(d => new { d.CompanyId, d.BIADocument, d.ProcessId })
                    .HasConstraintName("FK_tblBIARTO_tblBIAProceso");
            });

            modelBuilder.Entity<BIAWorkUnit>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.WorkUnitId });

                entity.ToTable("tblBIAUnidadTrabajo");

                entity.HasIndex(e => new { e.CompanyId, e.OUId })
                    .HasName("IX_FK_tblBIAUnidadTrabajo_tblUnidadOrganizativa");

                entity.Property(e => e.WorkUnitId).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.BIAWorkUnits)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAUnidadTrabajo_tblEmpresa");

                entity.HasOne(d => d.OUInfo)
                    .WithMany(p => p.BIAWorkUnits)
                    .HasForeignKey(d => new { d.CompanyId, d.OUId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAUnidadTrabajo_tblUnidadOrganizativa");
            });

            modelBuilder.Entity<BIAWorkUnitPerson>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.WorkUnitId, e.WorkUnitProcessId, e.PersonUnitId, e.ProcessClientId });

                entity.ToTable("tblBIAUnidadTrabajoPersonas");

                entity.HasIndex(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.ProcessClientId })
                    .HasName("IX_FK_tblBIAUnidadTrabajoPersonas_tblBIAClienteProceso");

                entity.Property(e => e.PersonUnitId).ValueGeneratedOnAdd();

                entity.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.BIAWorkUnitProcessInfo)
                    .WithMany(p => p.BIAWorkUnitPersons)
                    .HasForeignKey(d => new { d.CompanyId, d.WorkUnitId, d.WorkUnitProcessId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAUnidadTrabajoPersonas_tblBIAUnidadTrabajoProceso");

                entity.HasOne(d => d.BIACLientProcessInfo)
                    .WithMany(p => p.BIAWorkUnitPerson)
                    .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId, d.ProcessClientId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAUnidadTrabajoPersonas_tblBIAClienteProceso");
            });

            modelBuilder.Entity<BIAWorkUnitProcess>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.WorkUnitId, e.WorkUnitProcessId });

                entity.ToTable("tblBIAUnidadTrabajoProceso");

                entity.HasIndex(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId })
                    .HasName("IX_FK_tblBIAUnidadTrabajoProceso_tblBIAProceso");

                entity.Property(e => e.WorkUnitProcessId).ValueGeneratedOnAdd();

                entity.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.BIAWorkUnitInfo)
                    .WithMany(p => p.WorkUnitProcesses)
                    .HasForeignKey(d => new { d.CompanyId, d.WorkUnitId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAUnidadTrabajoProceso_tblBIAUnidadTrabajo");

                entity.HasOne(d => d.BIAProcessInfo)
                    .WithMany(p => p.BIAWorkUnitProcesses)
                    .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                    .HasConstraintName("FK_tblBIAUnidadTrabajoProceso_tblBIAProceso");
            });

            modelBuilder.Entity<BIAWRT>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.WRTId });

                entity.ToTable("tblBIAWRT");

                entity.HasIndex(e => e.FrecuencyTypeId)
                    .HasName("IX_FK_tblBIAWRT_tblTipoFrecuencia");

                entity.HasIndex(e => new { e.CompanyId, e.ScaleId })
                    .HasName("IX_FK_tblBIAWRT_tblEscala");

                entity.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.WRTId)
                    .HasColumnName("IdWRT")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.FrecuencyTypeInfo)
                    .WithMany(p => p.BIAWRTs)
                    .HasForeignKey(d => d.FrecuencyTypeId)
                    .HasConstraintName("FK_tblBIAWRT_tblTipoFrecuencia");

                entity.HasOne(d => d.ScaleInfo)
                    .WithMany(p => p.BIAWRTs)
                    .HasForeignKey(d => new { d.CompanyId, d.ScaleId })
                    .HasConstraintName("FK_tblBIAWRT_tblEscala");

                entity.HasOne(d => d.BiaProcessInfo)
                    .WithMany(p => p.BIAWRT)
                    .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                    .HasConstraintName("FK_tblBIAWRT_tblBIAProceso");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.PositionId });

                entity.ToTable("tblCargo");

                entity.Property(e => e.PositionId).ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.EmployeePositions)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblCargo_FK1");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => new { e.CountryId, e.StateId, e.CityId });

                entity.ToTable("tblCiudad");

                entity.HasOne(d => d.CountryInfo)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCiudad_tblPais");

                entity.HasOne(d => d.StateInfo)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => new { d.CountryId, d.StateId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCiudad_tblEstado");
            });

            modelBuilder.Entity<RiskControl>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ControlId });

                entity.ToTable("tblControlRiesgo");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Criticality>(entity =>
            {
                entity.HasKey(e => new { e.ApplicationDate, e.CompanyId, e.EscaleTypeId });

                entity.ToTable("tblCriticidad");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_FK_tblCriticidad_tblEmpresa");

                entity.HasIndex(e => new { e.CompanyId, e.EscaleTypeId })
                    .HasName("IX_FK_tblCriticidad_tblTipoEscala");

                entity.Property(e => e.ApplicationDate).HasColumnType("datetime");

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.Criticalitys)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCriticidad_tblEmpresa");

                entity.HasOne(d => d.ScaleInfo)
                    .WithMany(p => p.Citricities)
                    .HasForeignKey(d => new { d.CompanyId, d.EscaleTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCriticidad_tblTipoEscala");
            });

            modelBuilder.Entity<CityCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.CountryId, e.StateId, e.CityId });

                entity.ToTable("tblCultura_Ciudad");

                entity.HasIndex(e => new { e.CountryId, e.StateId, e.CityId })
                    .HasName("IX_FK_tblCulture_Ciudad_tblCiudad");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.HasOne(d => d.CityInfo)
                    .WithMany(p => p.CityCultures)
                    .HasForeignKey(d => new { d.CountryId, d.StateId, d.CityId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCulture_Ciudad_tblCiudad");
            });

            modelBuilder.Entity<CountryStateCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.CountryId, e.CountryStateId });

                entity.ToTable("tblCultura_Estado");

                entity.HasIndex(e => new { e.CountryId, e.CountryStateId })
                    .HasName("IX_FK_tblCultura_Estado_tblEstado");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.HasOne(d => d.CountryStateInfo)
                    .WithMany(p => p.CountryStateCultures)
                    .HasForeignKey(d => new { d.CountryId, d.CountryStateId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_Estado_tblEstado");
            });

            modelBuilder.Entity<DocumentStateCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.DocumentStateId });

                entity.ToTable("tblCultura_EstadoDocumento");

                entity.HasIndex(e => e.DocumentStateId)
                    .HasName("IX_FK_tblCultura_EstadoDocumento_tblEstadoDocumento");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.DocumentStateInfo)
                    .WithMany(p => p.DocumentStateCultures)
                    .HasForeignKey(d => d.DocumentStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_EstadoDocumento_tblEstadoDocumento");
            });

            modelBuilder.Entity<CompanyStateCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.CompanyStateId });

                entity.ToTable("tblCultura_EstadoEmpresa");

                entity.HasIndex(e => e.CompanyStateId)
                    .HasName("IX_FK_tblCultura_EstadoEmpresa_tblEstadoEmpresa");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CompanyStateInfo)
                    .WithMany(p => p.CompanyStateCultures)
                    .HasForeignKey(d => d.CompanyStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_EstadoEmpresa_tblEstadoEmpresa");
            });

            modelBuilder.Entity<ProcessStateCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.ProcessStateId });

                entity.ToTable("tblCultura_EstadoProceso");

                entity.HasIndex(e => e.ProcessStateId)
                    .HasName("IX_FK_tblCultura_EstadoProceso_tblEstadoProceso");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.ProcessStateInfo)
                    .WithMany(p => p.BIAProcessStateCultures)
                    .HasForeignKey(d => d.ProcessStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_EstadoProceso_tblEstadoProceso");
            });

            modelBuilder.Entity<UserSateCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.UserStateId });

                entity.ToTable("tblCultura_EstadoUsuario");

                entity.HasIndex(e => e.UserStateId)
                    .HasName("IX_FK_tblCultura_EstadoUsuario_tblEstadoUsuario");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.UserStateInfo)
                    .WithMany(p => p.UserStateCultures)
                    .HasForeignKey(d => d.UserStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_EstadoUsuario_tblEstadoUsuario");
            });

            modelBuilder.Entity<MonthCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.MonthId });

                entity.ToTable("tblCultura_Mes");

                entity.HasIndex(e => e.MonthId)
                    .HasName("IX_FK_tblCultura_Mes_tblMes");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.MonthInfo)
                    .WithMany(p => p.MonthCultures)
                    .HasForeignKey(d => d.MonthId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_Mes_tblMes");
            });

            modelBuilder.Entity<ImpactLevelCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.ImpactLevelId });

                entity.ToTable("tblCultura_NivelImpacto");

                entity.HasIndex(e => e.ImpactLevelId)
                    .HasName("IX_FK_tblCultura_NivelImpacto_tblNivelImpacto");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.ImpactLevelInfo)
                    .WithMany(p => p.ImpactLevelCultures)
                    .HasForeignKey(d => d.ImpactLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_NivelImpacto_tblNivelImpacto");
            });

            modelBuilder.Entity<CultureLevelUser>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.LevelUserId });

                entity.ToTable("tblCultura_NivelUsuario");

                entity.HasIndex(e => e.LevelUserId)
                    .HasName("IX_FK_tblCulture_NivelUsuario_tblNivelUsuario");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(450);

                entity.HasOne(d => d.LevelUserInfo)
                    .WithMany(p => p.UserLevelCultures)
                    .HasForeignKey(d => d.LevelUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCulture_NivelUsuario_tblNivelUsuario");
            });

            modelBuilder.Entity<CountryCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.CountryId });

                entity.ToTable("tblCultura_Pais");

                entity.HasIndex(e => e.CountryId)
                    .HasName("IX_FK_tblCulture_Pais_tblPais");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.HasOne(d => d.CountryInfo)
                    .WithMany(p => p.CountryCultures)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCulture_Pais_tblPais");
            });

            modelBuilder.Entity<PPETestStatusCulture>(entity =>
            {
                entity.HasKey(e => new { e.Cultura, e.StatusId });

                entity.ToTable("tblCultura_PBEPruebaEstatus");

                entity.HasIndex(e => e.StatusId)
                    .HasName("IX_FK_tblCultura_PBEPruebaEjecucionEstatus_tblPBEPruebaEjecucionEstatus");

                entity.Property(e => e.Cultura)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.PPETestStatusInfo)
                    .WithMany(p => p.PPETestStatusCultures)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_PBEPruebaEjecucionEstatus_tblPBEPruebaEjecucionEstatus");
            });

            modelBuilder.Entity<WorkScheduleStateCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.WorkScheduleStateId });

                entity.ToTable("tblCultura_PlanTrabajoEstatus");

                entity.HasIndex(e => e.WorkScheduleStateId)
                    .HasName("IX_FK_tblCultura_PlanTrabajoEstatus_tblPlanTrabajoEstatus");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(450);

                entity.HasOne(d => d.WorkScheduleStateInfo)
                    .WithMany(p => p.WorkScheduleStateCultures)
                    .HasForeignKey(d => d.WorkScheduleStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_PlanTrabajoEstatus_tblPlanTrabajoEstatus");
            });

            modelBuilder.Entity<PMTScheduleUpdateTypeCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.UpdateTypeId });

                entity.ToTable("tblCultura_PMTProgramacionTipoActualizacion");

                entity.HasIndex(e => e.UpdateTypeId)
                    .HasName("IX_FK_tblCultura_PMTProgramacionTipoActualizacion_tblPMTProgramacionTipoActualizacion");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.PMTScheduleUpdateTypeInfo)
                    .WithMany(p => p.PMTScheduleUpdateTypeCultures)
                    .HasForeignKey(d => d.UpdateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_PMTProgramacionTipoActualizacion_tblPMTProgramacionTipoActualizacion");
            });

            modelBuilder.Entity<PMTScheduleNotificationTypeCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.NotificationTypeId });

                entity.ToTable("tblCultura_PMTProgramacionTipoNotificacion");

                entity.HasIndex(e => e.NotificationTypeId)
                    .HasName("IX_FK_tblCultura_PMTProgramacionTipoNotificacion_tblPMTProgramacionTipoNotificacion");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.NotificationTypeInfo)
                    .WithMany(p => p.PMTScheduleNotificationTypeCultures)
                    .HasForeignKey(d => d.NotificationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_PMTProgramacionTipoNotificacion_tblPMTProgramacionTipoNotificacion");
            });

            modelBuilder.Entity<EmailTypeCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.EmailTypeId });

                entity.ToTable("tblCultura_TipoCorreo");

                entity.HasIndex(e => e.EmailTypeId)
                    .HasName("IX_FK_tblCultura_TipoCorreo_tblTipoCorreo");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.HasOne(d => d.EmailTypeInfo)
                    .WithMany(p => p.EmailTypeCultures)
                    .HasForeignKey(d => d.EmailTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoCorreo_tblTipoCorreo");
            });

            modelBuilder.Entity<AddressTypeCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.AddressTypeId });

                entity.ToTable("tblCultura_TipoDireccion");

                entity.HasIndex(e => e.AddressTypeId)
                    .HasName("IX_FK_tblCultura_TipoDireccion_tblTipoDireccion");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.AddressTypeInfo)
                    .WithMany(p => p.AddressTypeCultures)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoDireccion_tblTipoDireccion");
            });

            modelBuilder.Entity<FrecuencyTypeCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.FrecuencyTypeId });

                entity.ToTable("tblCultura_TipoFrecuencia");

                entity.HasIndex(e => e.FrecuencyTypeId)
                    .HasName("IX_FK_tblCultura_TipoFrecuencia_tblTipoFrecuencia");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(450);

                entity.HasOne(d => d.FrecuencyTypeInfo)
                    .WithMany(p => p.FrecuencyTypeCultures)
                    .HasForeignKey(d => d.FrecuencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoFrecuencia_tblTipoFrecuencia");
            });

            modelBuilder.Entity<ImpactTypeCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.ImpactTypeId });

                entity.ToTable("tblCultura_TipoImpacto");

                entity.HasIndex(e => e.ImpactTypeId)
                    .HasName("IX_FK_tblCultura_TipoImpacto_tblTipoImpacto");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.ImpactTypeInfo)
                    .WithMany(p => p.ImpactTypeCultures)
                    .HasForeignKey(d => d.ImpactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoImpacto_tblTipoImpacto");
            });

            modelBuilder.Entity<InterdependencyTypeCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.InterdependencyTypeId });

                entity.ToTable("tblCultura_TipoInterdependencia");

                entity.HasIndex(e => e.InterdependencyTypeId)
                    .HasName("IX_FK_tblCultura_TipoInterdependencia_tblTipoInterdependencia");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.InterdependencyTypeInfo)
                    .WithMany(p => p.InterdependencyTypeCultures)
                    .HasForeignKey(d => d.InterdependencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoInterdependencia_tblTipoInterdependencia");
            });

            modelBuilder.Entity<ResultTypeCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.ResultTypeId });

                entity.ToTable("tblCultura_TipoRespaldo");

                entity.HasIndex(e => e.ResultTypeId)
                    .HasName("IX_FK_tblCultura_TipoRespaldo_tblTipoRespaldo");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.ResultTypeInfo)
                    .WithMany(p => p.ResultTypeCultures)
                    .HasForeignKey(d => d.ResultTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoRespaldo_tblTipoRespaldo");
            });

            modelBuilder.Entity<TestResultTypeCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.TestResultTypeId });

                entity.ToTable("tblCultura_TipoResultadoPrueba");

                entity.HasIndex(e => e.TestResultTypeId)
                    .HasName("IX_FK_tblCultura_TipoResultadoPrueba_tblTipoResultadoPrueba");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.TestResultTypeInfo)
                    .WithMany(p => p.TestResultTypeCultures)
                    .HasForeignKey(d => d.TestResultTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoResultadoPrueba_tblTipoResultadoPrueba");
            });

            modelBuilder.Entity<TableTypeContentCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.TableTypeContentId });

                entity.ToTable("tblCultura_TipoTablaContenido");

                entity.HasIndex(e => e.TableTypeContentId)
                    .HasName("IX_FK_tblCultura_TipoTablaContenido_tblTipoTablaContenido");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.TableTypeContentInfo)
                    .WithMany(p => p.TableTypeContentCultures)
                    .HasForeignKey(d => d.TableTypeContentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoTablaContenido_tblTipoTablaContenido");
            });

            modelBuilder.Entity<PhoneTypeCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.PhoneTypeId });

                entity.ToTable("tblCultura_TipoTelefono");

                entity.HasIndex(e => e.PhoneTypeId)
                    .HasName("IX_FK_tblCultura_TipoTelefono_tblTipoTelefono");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.PhoneTypeInfo)
                    .WithMany(p => p.PhoneTypeCultures)
                    .HasForeignKey(d => d.PhoneTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoTelefono_tblTipoTelefono");
            });

            modelBuilder.Entity<LocationTypeInformationCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.LocationTypeInformationId });

                entity.ToTable("tblCultura_TipoUbicacionInformacion");

                entity.HasIndex(e => e.LocationTypeInformationId)
                    .HasName("IX_FK_tblCultura_TipoUbicacionInformacion_tblTipoUbicacionInformacion");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.HasOne(d => d.LocationTypeInformationInfo)
                    .WithMany(p => p.LocationTypeInformationCultures)
                    .HasForeignKey(d => d.LocationTypeInformationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoUbicacionInformacion_tblTipoUbicacionInformacion");
            });

            modelBuilder.Entity<IncidentSourceCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IncidentSourceId });

                entity.ToTable("tblCulture_FuenteIncidente");

                entity.HasIndex(e => e.IncidentSourceId)
                    .HasName("IX_FK_tblCulture_FuenteIncidente_tblFuenteIncidente");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.HasOne(d => d.IncidentSourceInfo)
                    .WithMany(p => p.IncidentSourceCultures)
                    .HasForeignKey(d => d.IncidentSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCulture_FuenteIncidente_tblFuenteIncidente");
            });

            modelBuilder.Entity<OriginIncidentCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.OriginIncidentId });

                entity.ToTable("tblCulture_NaturalezaIncidente");

                entity.HasIndex(e => e.OriginIncidentId)
                    .HasName("IX_FK_tblCulture_NaturalezaIncidente_tblNaturalezaIncidente");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.HasOne(d => d.OriginIncidentInfo)
                    .WithMany(p => p.OriginIncidentCultures)
                    .HasForeignKey(d => d.OriginIncidentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCulture_NaturalezaIncidente_tblNaturalezaIncidente");
            });

            modelBuilder.Entity<IncidentTypeCulture>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IncidentTypeId });

                entity.ToTable("tblCulture_TipoIncidente");

                entity.HasIndex(e => e.IncidentTypeId)
                    .HasName("IX_FK_tblCulture_TipoIncidente_tblTipoIncidente");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.HasOne(d => d.IncidentTypeInfo)
                    .WithMany(p => p.IncidentTypeCultures)
                    .HasForeignKey(d => d.IncidentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCulture_TipoIncidente_tblTipoIncidente");
            });

            modelBuilder.Entity<Device>(entity =>
            {
                entity.HasKey(e => e.DeviceId);

                entity.ToTable("tblDispositivo");

                entity.HasIndex(e => e.UserOwnerId)
                    .HasName("IX_FK_tblDispositivo_tblUsuario");

                entity.Property(e => e.MakerName).HasMaxLength(500);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.IMEI)
                    .HasColumnName("IMEI_Dispositivo")
                    .HasMaxLength(100);

                entity.Property(e => e.Model).HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Platform).HasMaxLength(500);

                entity.Property(e => e.DeviceType).HasMaxLength(500);

                entity.Property(e => e.Version).HasMaxLength(500);

                entity.HasOne(d => d.UserInfo)
                    .WithMany(p => p.MobileDevices)
                    .HasForeignKey(d => d.UserOwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDispositivo_tblUsuario");
            });

            modelBuilder.Entity<DeviceConnection>(entity =>
            {
                entity.HasKey(e => new { e.DeviceId, e.UserOwnerId, e.ConnectionDate });

                entity.ToTable("tblDispositivoConexion");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_FK_tblDispositivoConexion_tblEmpresa1");

                entity.Property(e => e.ConnectionDate).HasColumnType("datetime");

                entity.Property(e => e.IPAddress)
                    .HasColumnName("DirecciónIP")
                    .HasMaxLength(50);

                entity.HasOne(d => d.DeviceInfo)
                    .WithMany(p => p.DeviceConnections)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDispositivoConexion_tblDispositivo");

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.DeviceConnections)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tblDispositivoConexion_tblEmpresa");
            });

            modelBuilder.Entity<DeviceConsignment>(entity =>
            {
                entity.HasKey(e => new { e.DeviceId, e.UserOwnerId, e.CompanyId, e.SubmoduleId, e.UserConsignmentId, e.ConsignmentDate });

                entity.ToTable("tblDispositivoEnvio");

                entity.HasIndex(e => e.UserOwnerId)
                    .HasName("IX_FK_tblDispositivoEnvio_tblUsuarioRecibe");

                entity.HasIndex(e => e.UserConsignmentId)
                    .HasName("IX_FK_tblDispositivoEnvio_tblUsuarioEnvia");

                entity.HasIndex(e => new { e.CompanyId, e.SubmoduleId })
                    .HasName("IX_FK_tblDispositivoEnvio_tblEmpresaModulo");

                entity.Property(e => e.ConsignmentDate).HasColumnType("datetime");

                entity.Property(e => e.DownloadDate).HasColumnType("datetime");

                entity.HasOne(d => d.DeviceInfo)
                    .WithMany(p => p.DeviceConsignments)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDispositivoEnvio_tblDispositivo");

                entity.HasOne(d => d.UserOwnerInfo)
                    .WithMany(p => p.MobileDeviceReceivesByUser)
                    .HasForeignKey(d => d.UserOwnerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDispositivoEnvio_tblUsuarioRecibe");

                entity.HasOne(d => d.UserConsingmentInfo)
                    .WithMany(p => p.MobileDeviceSendsByUser)
                    .HasForeignKey(d => d.UserConsignmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDispositivoEnvio_tblUsuarioEnvia");

                entity.HasOne(d => d.CompanyMenuOptionInfo)
                    .WithMany(p => p.DeviceConsignment)
                    .HasForeignKey(d => new { d.CompanyId, d.SubmoduleId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDispositivoEnvio_tblEmpresaModulo");
            });

            modelBuilder.ApplyConfiguration(new DocumentConfiguration());

            modelBuilder.Entity<DocumentAttachment>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId, e.AttachmentId });

                entity.ToTable("tblDocumentoAnexo");

                entity.Property(e => e.AttachmentId).ValueGeneratedOnAdd();

                entity.Property(e => e.LastWriteTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.HasOne(d => d.DocumentInfo)
                    .WithMany(p => p.DocAttachments)
                    .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDocumentoAnexo_tblDocumento");
            });

            modelBuilder.Entity<DocumentApproval>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentType, e.ApprovalId });

                entity.ToTable("tblDocumentoAprobacion");

                entity.HasIndex(e => new { e.CompanyId, e.PersonId })
                    .HasName("IX_FK_tblDocumentoAprobacion_tblPersona");

                entity.Property(e => e.ApprovalId).ValueGeneratedOnAdd();

                entity.Property(e => e.ApprovalDate).HasColumnType("datetime");

                entity.HasOne(d => d.PersonInfo)
                    .WithMany(p => p.DocApprovals)
                    .HasForeignKey(d => new { d.CompanyId, d.PersonId })
                    .HasConstraintName("FK_tblDocumentoAprobacion_tblPersona");

                entity.HasOne(d => d.DocumentInfo)
                    .WithMany(p => p.DocumentAprovals)
                    .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentType })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAprobacion_tblDocumento");
            });

            modelBuilder.Entity<DocumentCertification>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId, e.CertificationId });

                entity.ToTable("tblDocumentoCertificacion");

                entity.HasIndex(e => new { e.CompanyId, e.PersonId })
                    .HasName("IX_FK_tblCertificacion_tblPersona");

                entity.Property(e => e.CertificationId).ValueGeneratedOnAdd();

                entity.Property(e => e.CertificationDate).HasColumnType("datetime");

                entity.HasOne(d => d.PersonInfo)
                    .WithMany(p => p.DocsCertifications)
                    .HasForeignKey(d => new { d.CompanyId, d.PersonId })
                    .HasConstraintName("FK_tblCertificacion_tblPersona");

                entity.HasOne(d => d.DocumentInfo)
                    .WithMany(p => p.DocumentCertifications)
                    .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCertificacion_tblDocumento");
            });

            modelBuilder.Entity<DocumentContent>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId, e.MenuOptionId });

                entity.ToTable("tblDocumentoContenido");

                entity.HasIndex(e => new { e.CompanyId, e.MenuOptionId })
                    .HasName("IX_FK_tblDocumentoContenido_tblModulo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.MenuOptionInfo)
                    .WithMany(p => p.DocumentContents)
                    .HasForeignKey(d => new { d.CompanyId, d.MenuOptionId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDocumentoContenido_tblModulo");

                entity.HasOne(d => d.DocumentInfo)
                    .WithMany(p => p.DocumentContents)
                    .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDocumentoContenido_tblDocumento");
            });

            modelBuilder.Entity<DocumentInterview>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId, e.InterviewId });

                entity.ToTable("tblDocumentoEntrevista");

                entity.Property(e => e.InterviewId).ValueGeneratedOnAdd();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.DocumentInfo)
                    .WithMany(p => p.DocumentInterviews)
                    .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDocumentoEntrevista_tblDocumento");
            });

            modelBuilder.Entity<DocumentInterviewPerson>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId, e.InterviewId, e.InterviewPersonId });

                entity.ToTable("tblDocumentoEntrevistaPersona");

                entity.Property(e => e.CompanyName).HasMaxLength(1500);

                entity.Property(e => e.Name).HasMaxLength(1500);

                entity.HasOne(d => d.DocumentInterviewInfo)
                    .WithMany(p => p.DocumentInterviewPersons)
                    .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId, d.InterviewId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDocumentoEntrevistaPersona_tblDocumentoEntrevista");
            });

            modelBuilder.Entity<DocumentKeyPerson>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId, e.PersonId });

                entity.ToTable("tblDocumentoPersonaClave");

                entity.HasIndex(e => new { e.CompanyId, e.PersonId })
                    .HasName("IX_FK_tblDocumentoPersonaClave_tblPersona");

                entity.Property(e => e.GovermentId)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.HomeAddress).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.MobilePhoneNumber)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.HomePhoneNumber)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.OfficePhoneNumber)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.DocVIPPersons)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPersonaClave_tblEmpresa");

                entity.HasOne(d => d.PersonInfo)
                    .WithMany(p => p.DocVIPPersons)
                    .HasForeignKey(d => new { d.CompanyId, d.PersonId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDocumentoPersonaClave_tblPersona");

                entity.HasOne(d => d.DocumentInfo)
                    .WithMany(p => p.DocumentVIPPersons)
                    .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDocumentoPersonaClave_tblDocumento");
            });

            modelBuilder.ApplyConfiguration(new CompanyConfiguration());

            modelBuilder.Entity<CompanyMenuOption>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.MenuOptionId });

                entity.ToTable("tblEmpresaModulo");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.CompanyMenuOptions)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresaModulo_tblEmpresa");

                entity.HasOne(d => d.MenuOpcionInfo)
                    .WithOne(p => p.CompanyMenuOption)
                    .HasForeignKey<CompanyMenuOption>(d => new { d.CompanyId, d.MenuOptionId })
                    .HasConstraintName("FK_tblEmpresaModulo_tblModulo");
            });

            modelBuilder.Entity<UserCompany>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.UserId });

                entity.ToTable("tblEmpresaUsuario");

                entity.HasIndex(e => e.LevelUserId)
                    .HasName("IX_FK_tblEmpresaUsuario_tblNivelUsuario");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_tblEmpresaUsuario_tblUsuario");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.CompanyUsers)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresaUsuario_tblEmpresa");

                entity.HasOne(d => d.UserLevelInfo)
                    .WithMany(p => p.UserCompanys)
                    .HasForeignKey(d => d.LevelUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresaUsuario_tblNivelUsuario");

                entity.HasOne(d => d.UserInfo)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresaUsuario_tblUsuario");
            });

            modelBuilder.Entity<Scale>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ScaleId });

                entity.ToTable("tblEscala");

                entity.HasIndex(e => new { e.CompanyId, e.ScaleTypeId })
                    .HasName("IX_FK_tblEscala_tblTipoEscala");

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.Scales)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblEscala_FK1");

                entity.HasOne(d => d.ScaleTypeInfo)
                    .WithMany(p => p.Scales)
                    .HasForeignKey(d => new { d.CompanyId, d.ScaleTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEscala_tblTipoEscala");
            });

            modelBuilder.Entity<CountryState>(entity =>
            {
                entity.HasKey(e => new { e.CountryId, e.CountryStateId });

                entity.ToTable("tblEstado");

                entity.HasOne(d => d.CountryInfo)
                    .WithMany(p => p.CountryStates)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPais_tblEstado_FK1");
            });

            modelBuilder.Entity<DocumentState>(entity =>
            {
                entity.HasKey(e => e.DocumentStateId);

                entity.ToTable("tblEstadoDocumento");

                entity.Property(e => e.DocumentStateId).ValueGeneratedNever();
            });

            modelBuilder.Entity<CompanyState>(entity =>
            {
                entity.HasKey(e => e.CompanyStateId);

                entity.ToTable("tblEstadoEmpresa");

                entity.Property(e => e.CompanyStateId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ProcessState>(entity =>
            {
                entity.HasKey(e => e.ProcessStateId);

                entity.ToTable("tblEstadoProceso");

                entity.Property(e => e.ProcessStateId).ValueGeneratedNever();
            });

            modelBuilder.Entity<RiskState>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.RiskStateId });

                entity.ToTable("tblEstadoRiesgo");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<UserState>(entity =>
            {
                entity.HasKey(e => e.UserStateId);

                entity.ToTable("tblEstadoUsuario");

                entity.Property(e => e.UserStateId).ValueGeneratedNever();
            });

            modelBuilder.Entity<EmailFormat>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.MenuCodeId, e.EmailId });

                entity.ToTable("tblFormatosEmail");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1500);

                entity.Property(e => e.EmailBody).IsRequired();

                entity.Property(e => e.Subject).HasMaxLength(450);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.EmailFormats)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblFormatosEmail_tblEmpresa");
            });

            modelBuilder.Entity<IncidentSource>(entity =>
            {
                entity.HasKey(e => e.IncidentSourceId);

                entity.ToTable("tblFuenteIncidente");
            });

            modelBuilder.Entity<RiskSource>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.SourceCode });

                entity.ToTable("tblFuenteRiesgo");

                entity.Property(e => e.SourceCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ImpactRisk>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ImpactId });

                entity.ToTable("tblImpactoRiesgo");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Incident>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.IncidentId });

                entity.ToTable("tblIncidentes");

                entity.HasIndex(e => e.SourceIncidentId)
                    .HasName("IX_FK_tblIncidentes_tblFuenteIncidente");

                entity.HasIndex(e => e.OriginIncidentId)
                    .HasName("IX_FK_tblIncidentes_tblNaturalezaIncidente");

                entity.HasIndex(e => e.IncidentType)
                    .HasName("IX_FK_tblIncidentes_tblTipoIncidente");

                entity.Property(e => e.IncidentId).ValueGeneratedOnAdd();

                entity.Property(e => e.IncidentDate).HasColumnType("datetime");

                entity.Property(e => e.ReporterName).HasMaxLength(500);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.Incidents)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIncidentes_tblEmpresa");

                entity.HasOne(d => d.IncidentSourceInfo)
                    .WithMany(p => p.Incidents)
                    .HasForeignKey(d => d.SourceIncidentId)
                    .HasConstraintName("FK_tblIncidentes_tblFuenteIncidente");

                entity.HasOne(d => d.OriginIncidentInfo)
                    .WithMany(p => p.Incidents)
                    .HasForeignKey(d => d.OriginIncidentId)
                    .HasConstraintName("FK_tblIncidentes_tblNaturalezaIncidente");

                entity.HasOne(d => d.IncidentTypeInfo)
                    .WithMany(p => p.Incidents)
                    .HasForeignKey(d => d.IncidentType)
                    .HasConstraintName("FK_tblIncidentes_tblTipoIncidente");
            });

            modelBuilder.Entity<IntitativePriority>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.PriorityId });

                entity.ToTable("tblIniciativaPrioridad");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Intiative>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.IntiativeId });

                entity.ToTable("tblIniciativas");

                entity.HasIndex(e => e.IntiativeStatusId)
                    .HasName("IX_FK_tblIniciativas_tblPlanTrabajoEstatus");

                entity.HasIndex(e => new { e.CompanyId, e.PriorityId })
                    .HasName("IX_FK_tblIniciativas_tblIniciativaPrioridad");

                entity.Property(e => e.IntiativeId).ValueGeneratedOnAdd();

                entity.Property(e => e.ScheduleEndDate).HasColumnType("datetime");

                entity.Property(e => e.RealEndDate).HasColumnType("datetime");

                entity.Property(e => e.ScheduleStartDate).HasColumnType("datetime");

                entity.Property(e => e.RealStartDate).HasColumnType("datetime");

                entity.Property(e => e.AmountPaid).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.AmountPending).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Name).HasMaxLength(1500);

                entity.Property(e => e.ResponsableName).HasMaxLength(1500);

                entity.Property(e => e.ProgressPercentage).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ScheduleBudget).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.RealBudget).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.OUName).HasMaxLength(1500);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.Initiatives)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIniciativas_tblEmpresa");

                entity.HasOne(d => d.ScheduleWorkStatus)
                    .WithMany(p => p.Intiatives)
                    .HasForeignKey(d => d.IntiativeStatusId)
                    .HasConstraintName("FK_tblIniciativas_tblPlanTrabajoEstatus");

                entity.HasOne(d => d.IntiativePriorityInfo)
                    .WithMany(p => p.Intiatives)
                    .HasForeignKey(d => new { d.CompanyId, d.PriorityId })
                    .HasConstraintName("FK_tblIniciativas_tblIniciativaPrioridad");
            });

            modelBuilder.Entity<IniciativeAttach>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.IniciativeId, e.AttachId });

                entity.ToTable("tblIniciativas_Anexo");

                entity.Property(e => e.AttachId).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("fechaRegistro")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(1500);

                entity.Property(e => e.FilePath).HasMaxLength(1500);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.InitiativesAttachments)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIniciativas_Anexo_tblEmpresa");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.LocationId });

                entity.ToTable("tblLocalidad");

                entity.HasIndex(e => e.CountryId)
                    .HasName("IX_FK_tblLocalidad_tblPais");

                entity.HasIndex(e => new { e.CountryId, e.StateId })
                    .HasName("IX_FK_tblLocalidad_tblEstado");

                entity.HasIndex(e => new { e.CountryId, e.StateId, e.CityId })
                    .HasName("IX_FK_tblLocalidad_tblCiudad");

                entity.Property(e => e.LocationId).ValueGeneratedOnAdd();

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblLocalidad_FK1");

                entity.HasOne(d => d.CountryInfo)
                    .WithMany(p => p.TblLocalidad)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblLocalidad_tblPais");

                entity.HasOne(d => d.StateInfo)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => new { d.CountryId, d.StateId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblLocalidad_tblEstado");

                entity.HasOne(d => d.CityInfo)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => new { d.CountryId, d.StateId, d.CityId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblLocalidad_tblCiudad");
            });

            modelBuilder.Entity<Month>(entity =>
            {
                entity.HasKey(e => e.MonthId);

                entity.ToTable("tblMes");

                entity.Property(e => e.MonthId).ValueGeneratedNever();
            });

            modelBuilder.Entity<MenuOption>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.MenuOptionId });

                entity.ToTable("tblModulo");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Controller)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(4000);

                entity.Property(e => e.ImageRoot)
                    .HasColumnName("imageRoot")
                    .HasMaxLength(500);

                entity.Property(e => e.Name).HasMaxLength(250);

                entity.Property(e => e.Title).HasMaxLength(450);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.MenuOptions)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_tblModulo_tblEmpresa");
            });

            modelBuilder.Entity<MenuAttach>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.MenuOptionId, e.ForBussiness, e.AttachId });

                entity.ToTable("tblModuloAnexo");

                entity.Property(e => e.AttachId).ValueGeneratedOnAdd();

                entity.Property(e => e.LastWriteTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.ModuleAttachments)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblModuloAnexo_tblEmpresa");
            });

            modelBuilder.Entity<MenuLevelUser>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.UserLevelId, e.MenuItemId });

                entity.ToTable("tblModulo_NivelUsuario");

                entity.HasIndex(e => e.UserLevelId)
                    .HasName("IX_FK_tblModulo_NivelUsuario_tblNivelUsuario");

                entity.HasIndex(e => new { e.CompanyId, e.MenuItemId })
                    .HasName("IX_FK_tblModulo_NivelUsuario_tblModulo");

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.UserLevelMenuOptions)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblModulo_NivelUsuario_tblEmpresa");

                entity.HasOne(d => d.UserLevelInfo)
                    .WithMany(p => p.UserLevelMenuOptions)
                    .HasForeignKey(d => d.UserLevelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblModulo_NivelUsuario_tblNivelUsuario");

                entity.HasOne(d => d.MenuOptionInfo)
                    .WithMany(p => p.UserMenuLevels)
                    .HasForeignKey(d => new { d.CompanyId, d.MenuItemId })
                    .HasConstraintName("FK_tblModulo_NivelUsuario_tblModulo");
            });

            modelBuilder.Entity<UserMenuOption>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.MenuOptionId, e.UserId });

                entity.ToTable("tblModulo_Usuario");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_tblModulo_Usuario_tblUsuario");

                entity.HasOne(d => d.UserInfo)
                    .WithMany(p => p.MenuOptions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblModulo_Usuario_tblUsuario");

                entity.HasOne(d => d.MenuOptionInfo)
                    .WithMany(p => p.UserMenuOptions)
                    .HasForeignKey(d => new { d.CompanyId, d.MenuOptionId })
                    .HasConstraintName("FK_tblModulo_Usuario_tblModulo");
            });

            modelBuilder.Entity<OriginIncident>(entity =>
            {
                entity.HasKey(e => e.OriginIncidentId);

                entity.ToTable("tblNaturalezaIncidente");
            });

            modelBuilder.Entity<ImpactLevel>(entity =>
            {
                entity.HasKey(e => e.ImpactLevelId);

                entity.ToTable("tblNivelImpacto");

                entity.Property(e => e.ImpactLevelId).ValueGeneratedNever();
            });

            modelBuilder.Entity<UserLevel>(entity =>
            {
                entity.HasKey(e => e.LevelUserId);

                entity.ToTable("tblNivelUsuario");

                entity.Property(e => e.LevelUserId).ValueGeneratedNever();

                entity.Property(e => e.UserRole)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("tblPais");

                entity.Property(e => e.CountryId).ValueGeneratedNever();
            });

            modelBuilder.Entity<PPETestExecution>(entity =>
            {
                entity.HasKey(e => new { e.CountryId, e.ScheduleId });

                entity.ToTable("tblPBEPruebaEjecucion");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.PPETestExecutions)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucion_tblEmpresa");

                entity.HasOne(d => d.PPETestScheduleInfo)
                    .WithOne(p => p.PPETestExecutionInfo)
                    .HasForeignKey<PPETestExecution>(d => new { d.CountryId, d.ScheduleId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucion_tblPBEPruebaPlanificacion");
            });

            modelBuilder.Entity<PPETestExecutionExercise>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ExerciseId });

                entity.ToTable("tblPBEPruebaEjecucionEjercicio");

                entity.HasIndex(e => e.StatusId)
                    .HasName("IX_FK_tblPBEPruebaEjecucionEjercicio_tblPBEPruebaEjecucionEstatus");

                entity.Property(e => e.ExerciseId).ValueGeneratedOnAdd();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.PPETestExecutionExersices)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicio_tblEmpresa");

                entity.HasOne(d => d.PPETestStatusInfo)
                    .WithMany(p => p.PPETestExecutionExercises)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicio_tblPBEPruebaEjecucionEstatus");

                entity.HasOne(d => d.PPEExecutionTestInfo)
                    .WithMany(p => p.PPETestExecutionExercises)
                    .HasForeignKey(d => new { d.CompanyId, d.ScheduleId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicio_tblPBEPruebaEjecucion");
            });

            modelBuilder.Entity<PPETestExecutionExerciseParticipant>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ExerciseId, e.ParticipantId });

                entity.ToTable("tblPBEPruebaEjecucionEjercicioParticipante");

                entity.HasIndex(e => new { e.CompanyId, e.ScheduleId, e.ParticipantId })
                    .HasName("IX_FK_tblPBEPruebaEjecucionEjercicioParticipante_tblPBEPruebaEjecucionParticipante");

                entity.HasOne(d => d.PPETestExecutionExerciseInfo)
                    .WithMany(p => p.PPETestExecutionExerciceParticipants)
                    .HasForeignKey(d => new { d.CompanyId, d.ScheduleId, d.ExerciseId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicioParticipante_tblPBEPruebaEjecucionEjercicio");

                entity.HasOne(d => d.PPETestExecutionParticipantInfo)
                    .WithMany(p => p.PPETestExecutionExerciceParticipants)
                    .HasForeignKey(d => new { d.CompanyId, d.ScheduleId, d.ParticipantId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicioParticipante_tblPBEPruebaEjecucionParticipante");
            });

            modelBuilder.Entity<PPETestExecutionExerciseResource>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ExerciseId, e.ResourceId });

                entity.ToTable("tblPBEPruebaEjecucionEjercicioRecurso");

                entity.Property(e => e.ResourceId).ValueGeneratedOnAdd();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.PPETestExecutionExerciseInfo)
                    .WithMany(p => p.PPETestExecutionExerciseResources)
                    .HasForeignKey(d => new { d.CompanyId, d.ScheduleId, d.ExerciseId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicioRecurso_tblPBEPruebaEjecucionEjercicio");
            });

            modelBuilder.Entity<PPETestExecutionParticipant>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ParticipantId });

                entity.ToTable("tblPBEPruebaEjecucionParticipante");

                entity.Property(e => e.ParticipantId).ValueGeneratedOnAdd();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.PPEExecutionTestInfo)
                    .WithMany(p => p.PPETestExecutionParticipants)
                    .HasForeignKey(d => new { d.CompanyId, d.ScheduleId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucionParticipante_tblPBEPruebaEjecucion");
            });

            modelBuilder.Entity<PPETestExecutionResult>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ContentId });

                entity.ToTable("tblPBEPruebaEjecucionResultado");

                entity.Property(e => e.Content).IsRequired();

                entity.HasOne(d => d.PPETestExecutionInfo)
                    .WithMany(p => p.PPETestExecutionResult)
                    .HasForeignKey(d => new { d.CompanyId, d.ScheduleId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucionResultado_tblPBEPruebaEjecucion");
            });

            modelBuilder.Entity<PPETestStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("tblPBEPruebaEstatus");

                entity.Property(e => e.StatusId).ValueGeneratedNever();
            });

            modelBuilder.Entity<PPETestSchedule>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ScheduleId });

                entity.ToTable("tblPBEPruebaPlanificacion");

                entity.Property(e => e.ScheduleId).ValueGeneratedOnAdd();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Purpose).IsRequired();

                entity.Property(e => e.Test)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.PPETestPlannings)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaPlanificacion_tblEmpresa");
            });

            modelBuilder.Entity<PPETestScheduleExercise>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ExerciseId });

                entity.ToTable("tblPBEPruebaPlanificacionEjercicio");

                entity.Property(e => e.ExerciseId).ValueGeneratedOnAdd();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.PPETestScheduleInfo)
                    .WithMany(p => p.PPETestScheduleExercises)
                    .HasForeignKey(d => new { d.CompanyId, d.ScheduleId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaPlanificacionEjercicio_tblPBEPruebaPlanificacion");
            });

            modelBuilder.Entity<PPETestScheduleExerciseParticipant>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ExerciseId, e.ParticipantId });

                entity.ToTable("tblPBEPruebaPlanificacionEjercicioParticipante");

                entity.HasIndex(e => new { e.CompanyId, e.ScheduleId, e.ParticipantId })
                    .HasName("IX_FK_tblPBEPruebaPlanificacionEjercicioParticipante_tblPBEPruebaPlanificacionParticipante");

                entity.HasOne(d => d.PPETestScheduleExerciseInfo)
                    .WithMany(p => p.PPETestScheduleExerciseParticipants)
                    .HasForeignKey(d => new { d.CompanyId, d.ScheduleId, d.ExerciseId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaPlanificacionEjercicioParticipante_tblPBEPruebaPlanificacionEjercicio");

                entity.HasOne(d => d.PPETestScheduleParticipantInfo)
                    .WithMany(p => p.PPETestScheduleExerciseParticipants)
                    .HasForeignKey(d => new { d.CompanyId, d.ScheduleId, d.ParticipantId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaPlanificacionEjercicioParticipante_tblPBEPruebaPlanificacionParticipante");
            });

            modelBuilder.Entity<PPETestScheduleExerciseResource>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ExerciseId, e.ResourceId });

                entity.ToTable("tblPBEPruebaPlanificacionEjercicioRecurso");

                entity.Property(e => e.ResourceId).ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.PPETestScheduleInfo)
                    .WithMany(p => p.PPETestScheduleExerciseResources)
                    .HasForeignKey(d => new { d.CompanyId, d.ScheduleId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaPlanificacionRecurso_tblPBEPruebaPlanificacion");

                entity.HasOne(d => d.PPETestScheduleExercise)
                    .WithMany(p => p.PPETestScheduleExerciseResources)
                    .HasForeignKey(d => new { d.CompanyId, d.ScheduleId, d.ExerciseId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaPlanificacionEjercicioRecurso_tblPBEPruebaPlanificacionEjercicio");
            });

            modelBuilder.Entity<PPETestScheduleParticipant>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ParticipantId });

                entity.ToTable("tblPBEPruebaPlanificacionParticipante");

                entity.Property(e => e.ParticipantId).ValueGeneratedOnAdd();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.PPETestScheduleInfo)
                    .WithMany(p => p.PPETestScheduleParticipants)
                    .HasForeignKey(d => new { d.CompanyId, d.ScheduleId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaPlanificacionParticipante_tblPBEPruebaPlanificacion");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.PersonId });

                entity.ToTable("tblPersona");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_tblPersona_tblUsuario");

                entity.HasIndex(e => new { e.CompanyId, e.PositionId })
                    .HasName("IX_FK_tblCargo_tblPersona_FK1");

                entity.HasIndex(e => new { e.CompanyId, e.OUId })
                    .HasName("IX_FK_tblPersona_tblUnidadOrganizativa");

                entity.Property(e => e.PersonId).ValueGeneratedOnAdd();

                entity.Property(e => e.DocumentIdentificationId).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblPersona_FK1");

                entity.HasOne(d => d.UserInfo)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_tblPersona_tblUsuario");

                entity.HasOne(d => d.PositionInfo)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => new { d.CompanyId, d.PositionId })
                    .HasConstraintName("FK_tblCargo_tblPersona_FK1");

                entity.HasOne(d => d.OUInfo)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => new { d.CompanyId, d.OUId })
                    .HasConstraintName("FK_tblPersona_tblUnidadOrganizativa");
            });

            modelBuilder.Entity<PersonEmail>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.PersonId, e.PersonEmailId });

                entity.ToTable("tblPersonaCorreo");

                entity.HasIndex(e => e.EmailTypeId)
                    .HasName("IX_FK_tblPersonaCorreo_tblTipoCorreo");

                entity.Property(e => e.PersonEmailId).ValueGeneratedOnAdd();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.EmailTypeInfo)
                    .WithMany(p => p.EmailPersons)
                    .HasForeignKey(d => d.EmailTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPersonaCorreo_tblTipoCorreo");

                entity.HasOne(d => d.PersonInfo)
                    .WithMany(p => p.PersonEmails)
                    .HasForeignKey(d => new { d.CompanyId, d.PersonId })
                    .HasConstraintName("FK_tblPersonaCorreo_tblPersona");
            });

            modelBuilder.Entity<PersonAddress>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.PersonId, e.PersonAddressId });

                entity.ToTable("tblPersonaDireccion");

                entity.HasIndex(e => e.CountryId)
                    .HasName("IX_FK_tblPersonaDireccion_tblPais");

                entity.HasIndex(e => e.AddressTypeId)
                    .HasName("IX_FK_tblPersonaDireccion_tblTipoDireccion");

                entity.HasIndex(e => new { e.CountryId, e.StateId })
                    .HasName("IX_FK_tblPersonaDireccion_tblEstado");

                entity.HasIndex(e => new { e.CountryId, e.StateId, e.CityId })
                    .HasName("IX_FK_tblPersonaDireccion_tblCiudad");

                entity.Property(e => e.PersonAddressId).ValueGeneratedOnAdd();

                entity.Property(e => e.LocationName).HasMaxLength(1500);

                entity.HasOne(d => d.CountryInfo)
                    .WithMany(p => p.TblPersonaDireccion)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPersonaDireccion_tblPais");

                entity.HasOne(d => d.AddressTypeInfo)
                    .WithMany(p => p.AddressPersons)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPersonaDireccion_tblTipoDireccion");

                entity.HasOne(d => d.PersonInfo)
                    .WithMany(p => p.PersonAddress)
                    .HasForeignKey(d => new { d.CompanyId, d.PersonId })
                    .HasConstraintName("FK_tblPersona_tblPersonaDireccion_FK1");

                entity.HasOne(d => d.StateInfo)
                    .WithMany(p => p.PersonAddresses)
                    .HasForeignKey(d => new { d.CountryId, d.StateId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPersonaDireccion_tblEstado");

                entity.HasOne(d => d.CityInfo)
                    .WithMany(p => p.PersonAddresses)
                    .HasForeignKey(d => new { d.CountryId, d.StateId, d.CityId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPersonaDireccion_tblCiudad");
            });

            modelBuilder.Entity<PersonPhone>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.PersonId, e.PersonPhoneId });

                entity.ToTable("tblPersonaTelefono");

                entity.HasIndex(e => e.PhoneTypeId)
                    .HasName("IX_FK_tblPersonaTelefono_tblTipoTelefono");

                entity.Property(e => e.PersonPhoneId).ValueGeneratedOnAdd();

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.PhoneTypeInfo)
                    .WithMany(p => p.PhonePersons)
                    .HasForeignKey(d => d.PhoneTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPersonaTelefono_tblTipoTelefono");

                entity.HasOne(d => d.PersonInfo)
                    .WithMany(p => p.PersonPhones)
                    .HasForeignKey(d => new { d.CompanyId, d.PersonId })
                    .HasConstraintName("FK_tblPersona_tblPersonaTelefono_FK1");
            });

            modelBuilder.Entity<WorkSchedule>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ActionId, e.ActivityId });

                entity.ToTable("tblPlanTrabajo");

                entity.HasIndex(e => e.Executed)
                    .HasName("IX_FK_tblPlanTrabajo_tblPlanTrabajoEstatus");

                entity.Property(e => e.ActivityId).ValueGeneratedOnAdd();

                entity.Property(e => e.ExecutionProposalDate).HasColumnType("datetime");

                entity.Property(e => e.Recommendation)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.WorkScheduleStateInfo)
                    .WithMany(p => p.WorkSchedules)
                    .HasForeignKey(d => d.Executed)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlanTrabajo_tblPlanTrabajoEstatus");

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.WorkSchedules)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlanTrabajo_tblEmpresa");

                entity.HasOne(d => d.WorkScheduleActionInfo)
                    .WithMany(p => p.WorkSchedules)
                    .HasForeignKey(d => new { d.CompanyId, d.ActionId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlanTrabajo_tblPlanTrabajoAccion");
            });

            modelBuilder.Entity<WorkScheduleAction>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ScheduleActionId });

                entity.ToTable("tblPlanTrabajoAccion");

                entity.Property(e => e.ScheduleActionId).ValueGeneratedOnAdd();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.WorkScheduleActions)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlanTrabajoAccion_tblEmpresa");
            });

            modelBuilder.Entity<WorkScheduleAudit>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ActionId, e.ActivityId, e.StateChangeId });

                entity.ToTable("tblPlanTrabajoAuditoria");

                entity.HasIndex(e => e.State)
                    .HasName("IX_FK_tblPlanTrabajoAuditoria_tblPlanTrabajoEstatus");

                entity.HasIndex(e => e.StateChangeUserId)
                    .HasName("IX_FK_tblPlanTrabajoAuditoria_tblUsuario");

                entity.Property(e => e.StateChangeId).ValueGeneratedOnAdd();

                entity.Property(e => e.StateChangeDate).HasColumnType("datetime");

                entity.HasOne(d => d.WorkScheduleStateInfo)
                    .WithMany(p => p.WorkScheduleAudits)
                    .HasForeignKey(d => d.State)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlanTrabajoAuditoria_tblPlanTrabajoEstatus");

                entity.HasOne(d => d.UserInfo)
                    .WithMany(p => p.WorkPlannAudits)
                    .HasForeignKey(d => d.StateChangeUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlanTrabajoAuditoria_tblUsuario");

                entity.HasOne(d => d.WorkScheduleActionInfo)
                    .WithMany(p => p.WorkScheduleAudits)
                    .HasForeignKey(d => new { d.CompanyId, d.ActionId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlanTrabajoAuditoria_tblPlanTrabajoAccion");

                entity.HasOne(d => d.WorkScheduleInfo)
                    .WithMany(p => p.WorkScheduleAudits)
                    .HasForeignKey(d => new { d.CompanyId, d.ActionId, d.ActivityId })
                    .HasConstraintName("FK_tblPlanTrabajoAuditoria_tblPlanTrabajo");
            });

            modelBuilder.Entity<WorkScheduleState>(entity =>
            {
                entity.HasKey(e => e.WorkScheduleStateId);

                entity.ToTable("tblPlanTrabajoEstatus");

                entity.Property(e => e.WorkScheduleStateId).ValueGeneratedNever();
            });

            modelBuilder.Entity<PMTMessageUpdate>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.MessageId, e.MenuOptionId });

                entity.ToTable("tblPMTMensajeActualizacion");

                entity.HasIndex(e => new { e.CompanyId, e.MenuOptionId })
                    .HasName("IX_FK_tblPMTMensajeActualizacion_tblModulo");

                entity.Property(e => e.MessageId).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.LastConsignmentDate).HasColumnType("datetime");

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.PMTMessageUpdates)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTMensajeActualizacion_tblEmpresa");

                entity.HasOne(d => d.MenuOptionInfo)
                    .WithMany(p => p.PMTMessageUpdates)
                    .HasForeignKey(d => new { d.CompanyId, d.MenuOptionId })
                    .HasConstraintName("FK_tblPMTMensajeActualizacion_tblModulo");
            });

            modelBuilder.Entity<PMTSchedule>(entity =>
            {
                entity.HasKey(e => e.PMTScheduleId);

                entity.ToTable("tblPMTProgramacion");

                entity.HasIndex(e => e.CompanyId)
                    .HasName("IX_FK_tblPMTProgramacion_tblEmpresa");

                entity.HasIndex(e => e.UpdateTypeId)
                    .HasName("IX_FK_tblPMTProgramacion_tblPMTProgramacionTipoActualizacion");

                entity.HasIndex(e => e.FrecuencyTypeId)
                    .HasName("IX_FK_tblPMTProgramacion_tblTipoFrecuencia");

                entity.HasIndex(e => new { e.CompanyId, e.MenuOptionId })
                    .HasName("IX_FK_tblPMTProgramacion_tblModulo");

                entity.Property(e => e.PMTScheduleId).HasColumnName("IdPMTProgramacion");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.CompanyIdInfo)
                    .WithMany(p => p.PMTSchedules)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacion_tblEmpresa");

                entity.HasOne(d => d.UpdateTypeInfo)
                    .WithMany(p => p.PMTSchedules)
                    .HasForeignKey(d => d.UpdateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacion_tblPMTProgramacionTipoActualizacion");

                entity.HasOne(d => d.FrecuencyTypeInfo)
                    .WithMany(p => p.PMTSchedules)
                    .HasForeignKey(d => d.FrecuencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacion_tblTipoFrecuencia");

                entity.HasOne(d => d.MenuOptionInfo)
                    .WithMany(p => p.PMTSchedules)
                    .HasForeignKey(d => new { d.CompanyId, d.MenuOptionId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacion_tblModulo");
            });

            modelBuilder.Entity<PMTScheduleDocument>(entity =>
            {
                entity.HasKey(e => new { e.PMTScheduleId, e.CompanyId, e.MenuOptionId, e.DocumentId });

                entity.ToTable("tblPMTProgramacionDocumentos");

                entity.HasIndex(e => new { e.CompanyId, e.MenuOptionId })
                    .HasName("IX_FK_tblPMTProgramacionDocumentos_tblModulo");

                entity.HasIndex(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId })
                    .HasName("IX_FK_tblPMTProgramacionDocumentos_tblDocumento");

                entity.Property(e => e.PMTScheduleId).HasColumnName("IdPMTProgramacion");

                entity.HasOne(d => d.PMTScheduleInfo)
                    .WithMany(p => p.PMTScheduleDocuments)
                    .HasForeignKey(d => d.PMTScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacionDocumentos_tblPMTProgramacion");

                entity.HasOne(d => d.MenuOptionInfo)
                    .WithMany(p => p.PMTScheduleDocuments)
                    .HasForeignKey(d => new { d.CompanyId, d.MenuOptionId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacionDocumentos_tblModulo");

                entity.HasOne(d => d.DocumentInfo)
                    .WithMany(p => p.PMTDocumentSchedules)
                    .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacionDocumentos_tblDocumento");
            });

            modelBuilder.Entity<PMTScheduleUpdateType>(entity =>
            {
                entity.HasKey(e => e.UpdateTypeId);

                entity.ToTable("tblPMTProgramacionTipoActualizacion");

                entity.Property(e => e.UpdateTypeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<PMTScheduleNotificationType>(entity =>
            {
                entity.HasKey(e => e.NotificationTypeId);

                entity.ToTable("tblPMTProgramacionTipoNotificacion");

                entity.Property(e => e.NotificationTypeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<PMTScheduleUser>(entity =>
            {
                entity.HasKey(e => new { e.PMTScheduleId, e.UserId });

                entity.ToTable("tblPMTProgramacionUsuario");

                entity.HasIndex(e => e.NotifyTypeId)
                    .HasName("IX_FK_tblPMTProgramacionUsuario_tblPMTProgramacionTipoNotificacion");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_tblPMTProgramacionUsuario_tblUsuario");

                entity.Property(e => e.PMTScheduleId).HasColumnName("IdPMTProgramacion");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.PMTScheduleInfo)
                    .WithMany(p => p.PMTScheduleUsers)
                    .HasForeignKey(d => d.PMTScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacionUsuario_tblPMTProgramacion");

                entity.HasOne(d => d.PMTScheduleNotifyTypeInfo)
                    .WithMany(p => p.PMTScheduleUsers)
                    .HasForeignKey(d => d.NotifyTypeId)
                    .HasConstraintName("FK_tblPMTProgramacionUsuario_tblPMTProgramacionTipoNotificacion");

                entity.HasOne(d => d.UserInfo)
                    .WithMany(p => p.MaintenancePlanSchedules)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacionUsuario_tblUsuario");
            });

            modelBuilder.Entity<PMTUpdateResponsable>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.MenuItemId, e.MessageId });

                entity.ToTable("tblPMTResponsableUpdate");

                entity.Property(e => e.MessageId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.PMTResponsibleUpdates)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTResponsableUpdate_tblEmpresa");

                entity.HasOne(d => d.MenuOptionInfo)
                    .WithMany(p => p.PMTResponsibleUpdates)
                    .HasForeignKey(d => new { d.CompanyId, d.MenuItemId })
                    .HasConstraintName("FK_tblPMTResponsableUpdate_tblModulo");
            });

            modelBuilder.Entity<PMTUpdateResponsableEmail>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.MenuOptionId, e.MessageId, e.UserId });

                entity.ToTable("tblPMTResponsableUpdate_Correo");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_tblPMTResponsableUpdate_Correo_tblUsuario");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.MaintenancePlanUpdateEmails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTResponsableUpdate_Correo_tblUsuario");

                entity.HasOne(d => d.PMTUpdateResponsableInfo)
                    .WithMany(p => p.PMTUpdateResponsableEmails)
                    .HasForeignKey(d => new { d.CompanyId, d.MenuOptionId, d.MessageId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTResponsableUpdate_Correo_tblPMTResponsableUpdate");
            });

            modelBuilder.Entity<PPEFrecuency>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId, e.PPEFrecuencyId });

                entity.ToTable("tblPPEFrecuencia");

                entity.HasIndex(e => e.FrecuencyTypeId)
                    .HasName("IX_FK_tblPPEFrecuencia_tblTipoFrecuencia");

                entity.Property(e => e.PPEFrecuencyId)
                    .HasColumnName("IdPPEFrecuencia")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Participants)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Purpose)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.TestType)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.FrecuencyTypeInfo)
                    .WithMany(p => p.PPEFrecuencies)
                    .HasForeignKey(d => d.FrecuencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPPEFrecuencia_tblTipoFrecuencia");

                entity.HasOne(d => d.DocumentInfo)
                    .WithMany(p => p.PPEFrecuencies)
                    .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPPEFrecuencia_tblDocumento");
            });

            modelBuilder.Entity<RiskProbability>(entity =>
            {
                entity.HasKey(e => new { e.ComanyId, e.ProbabilityId });

                entity.ToTable("tblProbabilidadRiesgo");

                entity.Property(e => e.GraphicLabel).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.RiskProbabilities)
                    .HasForeignKey(d => d.ComanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAProbabilidadRiesgo_tblEmpresa");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ProductId });

                entity.ToTable("tblProducto");

                entity.Property(e => e.ProductId).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProducto_tblEmpresa");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ProviderId });

                entity.ToTable("tblProveedor");

                entity.Property(e => e.ProviderId).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.Providers)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblProveedor_FK1");
            });

            modelBuilder.Entity<RiskSeverity>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.SeveriryId });

                entity.ToTable("tblSeveridadRiesgo");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<EmailType>(entity =>
            {
                entity.HasKey(e => e.EmailTypeId);

                entity.ToTable("tblTipoCorreo");

                entity.Property(e => e.EmailTypeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.HasKey(e => e.AddressTypeId);

                entity.ToTable("tblTipoDireccion");

                entity.Property(e => e.AddressTypeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ScaleType>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.ScaleTypeId });

                entity.ToTable("tblTipoEscala");

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<FrecuencyType>(entity =>
            {
                entity.HasKey(e => e.FrecuencyTypeId);

                entity.ToTable("tblTipoFrecuencia");

                entity.Property(e => e.FrecuencyTypeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ImpactType>(entity =>
            {
                entity.HasKey(e => e.ImpactTypeId);

                entity.ToTable("tblTipoImpacto");

                entity.Property(e => e.ImpactTypeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<IncidentType>(entity =>
            {
                entity.HasKey(e => e.IncidentTypeId);

                entity.ToTable("tblTipoIncidente");
            });

            modelBuilder.Entity<InterdependencyType>(entity =>
            {
                entity.HasKey(e => e.InterdependencyTypeId);

                entity.ToTable("tblTipoInterdependencia");

                entity.Property(e => e.InterdependencyTypeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ResultType>(entity =>
            {
                entity.HasKey(e => e.ResultTypeId);

                entity.ToTable("tblTipoRespaldo");

                entity.Property(e => e.ResultTypeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<TestResultType>(entity =>
            {
                entity.HasKey(e => e.TestResultTypeId);

                entity.ToTable("tblTipoResultadoPrueba");

                entity.Property(e => e.TestResultTypeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<TableTypeContent>(entity =>
            {
                entity.HasKey(e => e.TableTypeContentId);

                entity.ToTable("tblTipoTablaContenido");

                entity.Property(e => e.TableTypeContentId).ValueGeneratedNever();
            });

            modelBuilder.Entity<PhoneType>(entity =>
            {
                entity.HasKey(e => e.PhoneTypeId);

                entity.ToTable("tblTipoTelefono");

                entity.Property(e => e.PhoneTypeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<LocationTypeInformation>(entity =>
            {
                entity.HasKey(e => e.LocationTypeInformationId);

                entity.ToTable("tblTipoUbicacionInformacion");

                entity.Property(e => e.LocationTypeInformationId).ValueGeneratedNever();
            });

            modelBuilder.Entity<OrganizationUnit>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.OrganizationUnitId });

                entity.ToTable("tblUnidadOrganizativa");

                entity.Property(e => e.OrganizationUnitId).ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.UOs)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblUnidadOrganizativa_FK1");
            });

            modelBuilder.ApplyConfiguration(new UserConfiguration());

            modelBuilder.Entity<UserOrganizationUnit>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.OrganizationUnitId, e.UserId });

                entity.ToTable("tblUsuarioUnidadOrganizativa");

                entity.HasIndex(e => e.LevelUserId)
                    .HasName("IX_FK_tblUsuarioUnidadOrganizativa_tblNivelUsuario");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_FK_tblUsuarioUnidadOrganizativa_tblUsuario");

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.UserUOs)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUsuarioUnidadOrganizativa_tblEmpresa");

                entity.HasOne(d => d.UserLevelInfo)
                    .WithMany(p => p.UserOUs)
                    .HasForeignKey(d => d.LevelUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUsuarioUnidadOrganizativa_tblNivelUsuario");

                entity.HasOne(d => d.UserInfo)
                    .WithMany(p => p.OrganizationUnits)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUsuarioUnidadOrganizativa_tblUsuario");

                entity.HasOne(d => d.OrganizationUnitInfo)
                    .WithMany(p => p.UserOUs)
                    .HasForeignKey(d => new { d.CompanyId, d.OrganizationUnitId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUsuarioUnidadOrganizativa_tblUnidadOrganizativa");
            });

            modelBuilder.Entity<VicePresidency>(entity =>
            {
                entity.HasKey(e => new { e.CompanyId, e.VicepresidencyId });

                entity.ToTable("tblVicepresidencia");

                entity.HasIndex(e => e.CountryId)
                    .HasName("IX_FK_tblVicepresidencia_tblPais");

                entity.Property(e => e.VicepresidencyId).ValueGeneratedOnAdd();

                entity.Property(e => e.AvenueStreetName)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.BuildingHouseName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.FloorLevel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TowerSideName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.UrbanizationName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.CompanyInfo)
                    .WithMany(p => p.Vicepresidences)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblVicepresidencia_FK1");

                entity.HasOne(d => d.CountryInfo)
                    .WithMany(p => p.TblVicepresidencia)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVicepresidencia_tblPais");
            });
        }
    }
}
