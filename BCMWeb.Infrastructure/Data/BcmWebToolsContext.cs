using BCMWeb.Core.Entities;
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

        public virtual DbSet<TblAuditoria> TblAuditoria { get; set; }
        public virtual DbSet<TblAuditoriaProcesoCritico> TblAuditoriaProcesoCritico { get; set; }
        public virtual DbSet<TblBcpdocumento> TblBcpdocumento { get; set; }
        public virtual DbSet<TblBcpreanudacionPersonaClave> TblBcpreanudacionPersonaClave { get; set; }
        public virtual DbSet<TblBcpreanudacionTarea> TblBcpreanudacionTarea { get; set; }
        public virtual DbSet<TblBcpreanudacionTareaActividad> TblBcpreanudacionTareaActividad { get; set; }
        public virtual DbSet<TblBcprecuperacionPersonaClave> TblBcprecuperacionPersonaClave { get; set; }
        public virtual DbSet<TblBcprecuperacionRecurso> TblBcprecuperacionRecurso { get; set; }
        public virtual DbSet<TblBcprespuestaAccion> TblBcprespuestaAccion { get; set; }
        public virtual DbSet<TblBcprespuestaRecurso> TblBcprespuestaRecurso { get; set; }
        public virtual DbSet<TblBcprestauracionEquipo> TblBcprestauracionEquipo { get; set; }
        public virtual DbSet<TblBcprestauracionInfraestructura> TblBcprestauracionInfraestructura { get; set; }
        public virtual DbSet<TblBcprestauracionMobiliario> TblBcprestauracionMobiliario { get; set; }
        public virtual DbSet<TblBcprestauracionOtro> TblBcprestauracionOtro { get; set; }
        public virtual DbSet<TblBiaamenaza> TblBiaamenaza { get; set; }
        public virtual DbSet<TblBiaamenazaEvento> TblBiaamenazaEvento { get; set; }
        public virtual DbSet<TblBiaaplicacion> TblBiaaplicacion { get; set; }
        public virtual DbSet<TblBiacadenaServicio> TblBiacadenaServicio { get; set; }
        public virtual DbSet<TblBiaclienteProceso> TblBiaclienteProceso { get; set; }
        public virtual DbSet<TblBiacomentario> TblBiacomentario { get; set; }
        public virtual DbSet<TblBiadocumentacion> TblBiadocumentacion { get; set; }
        public virtual DbSet<TblBiadocumento> TblBiadocumento { get; set; }
        public virtual DbSet<TblBiaentrada> TblBiaentrada { get; set; }
        public virtual DbSet<TblBiaeventoControl> TblBiaeventoControl { get; set; }
        public virtual DbSet<TblBiaeventoRiesgo> TblBiaeventoRiesgo { get; set; }
        public virtual DbSet<TblBiagranImpacto> TblBiagranImpacto { get; set; }
        public virtual DbSet<TblBiaimpactoFinanciero> TblBiaimpactoFinanciero { get; set; }
        public virtual DbSet<TblBiaimpactoOperacional> TblBiaimpactoOperacional { get; set; }
        public virtual DbSet<TblBiainterdependencia> TblBiainterdependencia { get; set; }
        public virtual DbSet<TblBiamtd> TblBiamtd { get; set; }
        public virtual DbSet<TblBiapersonaClave> TblBiapersonaClave { get; set; }
        public virtual DbSet<TblBiapersonaRespaldoProceso> TblBiapersonaRespaldoProceso { get; set; }
        public virtual DbSet<TblBiaproceso> TblBiaproceso { get; set; }
        public virtual DbSet<TblBiaprocesoAlterno> TblBiaprocesoAlterno { get; set; }
        public virtual DbSet<TblBiaproveedor> TblBiaproveedor { get; set; }
        public virtual DbSet<TblBiarespaldoPrimario> TblBiarespaldoPrimario { get; set; }
        public virtual DbSet<TblBiarespaldoSecundario> TblBiarespaldoSecundario { get; set; }
        public virtual DbSet<TblBiarpo> TblBiarpo { get; set; }
        public virtual DbSet<TblBiarto> TblBiarto { get; set; }
        public virtual DbSet<TblBiaunidadTrabajo> TblBiaunidadTrabajo { get; set; }
        public virtual DbSet<TblBiaunidadTrabajoPersonas> TblBiaunidadTrabajoPersonas { get; set; }
        public virtual DbSet<TblBiaunidadTrabajoProceso> TblBiaunidadTrabajoProceso { get; set; }
        public virtual DbSet<TblBiawrt> TblBiawrt { get; set; }
        public virtual DbSet<TblCargo> TblCargo { get; set; }
        public virtual DbSet<TblCiudad> TblCiudad { get; set; }
        public virtual DbSet<TblControlRiesgo> TblControlRiesgo { get; set; }
        public virtual DbSet<TblCriticidad> TblCriticidad { get; set; }
        public virtual DbSet<TblCulturaCiudad> TblCulturaCiudad { get; set; }
        public virtual DbSet<TblCulturaEstado> TblCulturaEstado { get; set; }
        public virtual DbSet<TblCulturaEstadoDocumento> TblCulturaEstadoDocumento { get; set; }
        public virtual DbSet<TblCulturaEstadoEmpresa> TblCulturaEstadoEmpresa { get; set; }
        public virtual DbSet<TblCulturaEstadoProceso> TblCulturaEstadoProceso { get; set; }
        public virtual DbSet<TblCulturaEstadoUsuario> TblCulturaEstadoUsuario { get; set; }
        public virtual DbSet<TblCulturaMes> TblCulturaMes { get; set; }
        public virtual DbSet<TblCulturaNivelImpacto> TblCulturaNivelImpacto { get; set; }
        public virtual DbSet<TblCulturaNivelUsuario> TblCulturaNivelUsuario { get; set; }
        public virtual DbSet<TblCulturaPais> TblCulturaPais { get; set; }
        public virtual DbSet<TblCulturaPbepruebaEstatus> TblCulturaPbepruebaEstatus { get; set; }
        public virtual DbSet<TblCulturaPlanTrabajoEstatus> TblCulturaPlanTrabajoEstatus { get; set; }
        public virtual DbSet<TblCulturaPmtprogramacionTipoActualizacion> TblCulturaPmtprogramacionTipoActualizacion { get; set; }
        public virtual DbSet<TblCulturaPmtprogramacionTipoNotificacion> TblCulturaPmtprogramacionTipoNotificacion { get; set; }
        public virtual DbSet<TblCulturaTipoCorreo> TblCulturaTipoCorreo { get; set; }
        public virtual DbSet<TblCulturaTipoDireccion> TblCulturaTipoDireccion { get; set; }
        public virtual DbSet<TblCulturaTipoFrecuencia> TblCulturaTipoFrecuencia { get; set; }
        public virtual DbSet<TblCulturaTipoImpacto> TblCulturaTipoImpacto { get; set; }
        public virtual DbSet<TblCulturaTipoInterdependencia> TblCulturaTipoInterdependencia { get; set; }
        public virtual DbSet<TblCulturaTipoRespaldo> TblCulturaTipoRespaldo { get; set; }
        public virtual DbSet<TblCulturaTipoResultadoPrueba> TblCulturaTipoResultadoPrueba { get; set; }
        public virtual DbSet<TblCulturaTipoTablaContenido> TblCulturaTipoTablaContenido { get; set; }
        public virtual DbSet<TblCulturaTipoTelefono> TblCulturaTipoTelefono { get; set; }
        public virtual DbSet<TblCulturaTipoUbicacionInformacion> TblCulturaTipoUbicacionInformacion { get; set; }
        public virtual DbSet<TblCultureFuenteIncidente> TblCultureFuenteIncidente { get; set; }
        public virtual DbSet<TblCultureNaturalezaIncidente> TblCultureNaturalezaIncidente { get; set; }
        public virtual DbSet<TblCultureTipoIncidente> TblCultureTipoIncidente { get; set; }
        public virtual DbSet<TblDispositivo> TblDispositivo { get; set; }
        public virtual DbSet<TblDispositivo1> TblDispositivo1 { get; set; }
        public virtual DbSet<TblDispositivoConexion> TblDispositivoConexion { get; set; }
        public virtual DbSet<TblDispositivoConexion1> TblDispositivoConexion1 { get; set; }
        public virtual DbSet<TblDispositivoEnvio> TblDispositivoEnvio { get; set; }
        public virtual DbSet<TblDispositivoEnvio1> TblDispositivoEnvio1 { get; set; }
        public virtual DbSet<TblDocumento> TblDocumento { get; set; }
        public virtual DbSet<TblDocumentoAnexo> TblDocumentoAnexo { get; set; }
        public virtual DbSet<TblDocumentoAprobacion> TblDocumentoAprobacion { get; set; }
        public virtual DbSet<TblDocumentoCertificacion> TblDocumentoCertificacion { get; set; }
        public virtual DbSet<TblDocumentoContenido> TblDocumentoContenido { get; set; }
        public virtual DbSet<TblDocumentoEntrevista> TblDocumentoEntrevista { get; set; }
        public virtual DbSet<TblDocumentoEntrevistaPersona> TblDocumentoEntrevistaPersona { get; set; }
        public virtual DbSet<TblDocumentoPersonaClave> TblDocumentoPersonaClave { get; set; }
        public virtual DbSet<TblEmpresa> TblEmpresa { get; set; }
        public virtual DbSet<TblEmpresaModulo> TblEmpresaModulo { get; set; }
        public virtual DbSet<TblEmpresaUsuario> TblEmpresaUsuario { get; set; }
        public virtual DbSet<TblEscala> TblEscala { get; set; }
        public virtual DbSet<TblEstado> TblEstado { get; set; }
        public virtual DbSet<TblEstadoDocumento> TblEstadoDocumento { get; set; }
        public virtual DbSet<TblEstadoEmpresa> TblEstadoEmpresa { get; set; }
        public virtual DbSet<TblEstadoProceso> TblEstadoProceso { get; set; }
        public virtual DbSet<TblEstadoRiesgo> TblEstadoRiesgo { get; set; }
        public virtual DbSet<TblEstadoUsuario> TblEstadoUsuario { get; set; }
        public virtual DbSet<TblFormatosEmail> TblFormatosEmail { get; set; }
        public virtual DbSet<TblFuenteIncidente> TblFuenteIncidente { get; set; }
        public virtual DbSet<TblFuenteRiesgo> TblFuenteRiesgo { get; set; }
        public virtual DbSet<TblImpactoRiesgo> TblImpactoRiesgo { get; set; }
        public virtual DbSet<TblIncidentes> TblIncidentes { get; set; }
        public virtual DbSet<TblIniciativaPrioridad> TblIniciativaPrioridad { get; set; }
        public virtual DbSet<TblIniciativaResponsable> TblIniciativaResponsable { get; set; }
        public virtual DbSet<TblIniciativas> TblIniciativas { get; set; }
        public virtual DbSet<TblIniciativasAnexo> TblIniciativasAnexo { get; set; }
        public virtual DbSet<TblLocalidad> TblLocalidad { get; set; }
        public virtual DbSet<TblMes> TblMes { get; set; }
        public virtual DbSet<TblModulo> TblModulo { get; set; }
        public virtual DbSet<TblModuloAnexo> TblModuloAnexo { get; set; }
        public virtual DbSet<TblModuloNivelUsuario> TblModuloNivelUsuario { get; set; }
        public virtual DbSet<TblModuloUsuario> TblModuloUsuario { get; set; }
        public virtual DbSet<TblNaturalezaIncidente> TblNaturalezaIncidente { get; set; }
        public virtual DbSet<TblNivelImpacto> TblNivelImpacto { get; set; }
        public virtual DbSet<TblNivelUsuario> TblNivelUsuario { get; set; }
        public virtual DbSet<TblPais> TblPais { get; set; }
        public virtual DbSet<TblPbepruebaEjecucion> TblPbepruebaEjecucion { get; set; }
        public virtual DbSet<TblPbepruebaEjecucionEjercicio> TblPbepruebaEjecucionEjercicio { get; set; }
        public virtual DbSet<TblPbepruebaEjecucionEjercicioParticipante> TblPbepruebaEjecucionEjercicioParticipante { get; set; }
        public virtual DbSet<TblPbepruebaEjecucionEjercicioRecurso> TblPbepruebaEjecucionEjercicioRecurso { get; set; }
        public virtual DbSet<TblPbepruebaEjecucionParticipante> TblPbepruebaEjecucionParticipante { get; set; }
        public virtual DbSet<TblPbepruebaEjecucionResultado> TblPbepruebaEjecucionResultado { get; set; }
        public virtual DbSet<TblPbepruebaEstatus> TblPbepruebaEstatus { get; set; }
        public virtual DbSet<TblPbepruebaPlanificacion> TblPbepruebaPlanificacion { get; set; }
        public virtual DbSet<TblPbepruebaPlanificacionEjercicio> TblPbepruebaPlanificacionEjercicio { get; set; }
        public virtual DbSet<TblPbepruebaPlanificacionEjercicioParticipante> TblPbepruebaPlanificacionEjercicioParticipante { get; set; }
        public virtual DbSet<TblPbepruebaPlanificacionEjercicioRecurso> TblPbepruebaPlanificacionEjercicioRecurso { get; set; }
        public virtual DbSet<TblPbepruebaPlanificacionParticipante> TblPbepruebaPlanificacionParticipante { get; set; }
        public virtual DbSet<TblPersona> TblPersona { get; set; }
        public virtual DbSet<TblPersonaCorreo> TblPersonaCorreo { get; set; }
        public virtual DbSet<TblPersonaDireccion> TblPersonaDireccion { get; set; }
        public virtual DbSet<TblPersonaTelefono> TblPersonaTelefono { get; set; }
        public virtual DbSet<TblPlanTrabajo> TblPlanTrabajo { get; set; }
        public virtual DbSet<TblPlanTrabajoAccion> TblPlanTrabajoAccion { get; set; }
        public virtual DbSet<TblPlanTrabajoAuditoria> TblPlanTrabajoAuditoria { get; set; }
        public virtual DbSet<TblPlanTrabajoEstatus> TblPlanTrabajoEstatus { get; set; }
        public virtual DbSet<TblPmtmensajeActualizacion> TblPmtmensajeActualizacion { get; set; }
        public virtual DbSet<TblPmtprogramacion> TblPmtprogramacion { get; set; }
        public virtual DbSet<TblPmtprogramacionDocumentos> TblPmtprogramacionDocumentos { get; set; }
        public virtual DbSet<TblPmtprogramacionTipoActualizacion> TblPmtprogramacionTipoActualizacion { get; set; }
        public virtual DbSet<TblPmtprogramacionTipoNotificacion> TblPmtprogramacionTipoNotificacion { get; set; }
        public virtual DbSet<TblPmtprogramacionUsuario> TblPmtprogramacionUsuario { get; set; }
        public virtual DbSet<TblPmtresponsableUpdate> TblPmtresponsableUpdate { get; set; }
        public virtual DbSet<TblPmtresponsableUpdateCorreo> TblPmtresponsableUpdateCorreo { get; set; }
        public virtual DbSet<TblPpefrecuencia> TblPpefrecuencia { get; set; }
        public virtual DbSet<TblProbabilidadRiesgo> TblProbabilidadRiesgo { get; set; }
        public virtual DbSet<TblProducto> TblProducto { get; set; }
        public virtual DbSet<TblProveedor> TblProveedor { get; set; }
        public virtual DbSet<TblSeveridadRiesgo> TblSeveridadRiesgo { get; set; }
        public virtual DbSet<TblTipoCorreo> TblTipoCorreo { get; set; }
        public virtual DbSet<TblTipoDireccion> TblTipoDireccion { get; set; }
        public virtual DbSet<TblTipoEscala> TblTipoEscala { get; set; }
        public virtual DbSet<TblTipoFrecuencia> TblTipoFrecuencia { get; set; }
        public virtual DbSet<TblTipoImpacto> TblTipoImpacto { get; set; }
        public virtual DbSet<TblTipoIncidente> TblTipoIncidente { get; set; }
        public virtual DbSet<TblTipoInterdependencia> TblTipoInterdependencia { get; set; }
        public virtual DbSet<TblTipoRespaldo> TblTipoRespaldo { get; set; }
        public virtual DbSet<TblTipoResultadoPrueba> TblTipoResultadoPrueba { get; set; }
        public virtual DbSet<TblTipoTablaContenido> TblTipoTablaContenido { get; set; }
        public virtual DbSet<TblTipoTelefono> TblTipoTelefono { get; set; }
        public virtual DbSet<TblTipoUbicacionInformacion> TblTipoUbicacionInformacion { get; set; }
        public virtual DbSet<TblUnidadOrganizativa> TblUnidadOrganizativa { get; set; }
        public virtual DbSet<User> TblUsuario { get; set; }
        public virtual DbSet<TblUsuarioUnidadOrganizativa> TblUsuarioUnidadOrganizativa { get; set; }
        public virtual DbSet<TblVicepresidencia> TblVicepresidencia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAuditoria>(entity =>
            {
                entity.HasKey(e => e.IdAuditoria);

                entity.ToTable("tblAuditoria");

                entity.HasIndex(e => e.IdEmpresa)
                    .HasName("IX_FK_tblEmpresa_tblAuditoria_FK1");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("IX_FK_tblUsuario_tblAuditoria_FK1");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdDocumento, e.IdTipoDocumento })
                    .HasName("IX_FK_tblAuditoria_tblDocumento");

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DireccionIp)
                    .IsRequired()
                    .HasColumnName("DireccionIP")
                    .HasMaxLength(250);

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.Mensaje)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblAuditoria)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK_tblEmpresa_tblAuditoria_FK1");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Audits)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_tblUsuario_tblAuditoria_FK1");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblAuditoria)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumento, d.IdTipoDocumento })
                    .HasConstraintName("FK_tblAuditoria_tblDocumento");
            });

            modelBuilder.Entity<TblAuditoriaProcesoCritico>(entity =>
            {
                entity.HasKey(e => new { e.IdProceso, e.IdAuditoriaProcesoCritico });

                entity.ToTable("tblAuditoriaProcesoCritico");

                entity.HasIndex(e => e.IdEmpresa)
                    .HasName("IX_FK_tblAuditoriaProcesoCritico_tblEmpresa");

                entity.Property(e => e.IdAuditoriaProcesoCritico).ValueGeneratedOnAdd();

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblAuditoriaProcesoCritico)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAuditoriaProcesoCritico_tblEmpresa");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.AuditCriticalProcesses)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAuditoriaProcesoCritico_tblUsuario");
            });

            modelBuilder.Entity<TblBcpdocumento>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBcp });

                entity.ToTable("tblBCPDocumento");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdDocumento, e.IdTipoDocumento })
                    .HasName("IX_FK_tblBCPDocumento_tblDocumento");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso })
                    .HasName("IX_FK_tblBCPDocumento_tblBIAProceso");

                entity.Property(e => e.IdDocumentoBcp)
                    .HasColumnName("IdDocumentoBCP")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.Proceso).HasMaxLength(500);

                entity.Property(e => e.Responsable).HasMaxLength(500);

                entity.Property(e => e.SubProceso).HasMaxLength(500);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblBcpdocumento)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblBCPDocumento_FK1");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBcpdocumento)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumento, d.IdTipoDocumento })
                    .HasConstraintName("FK_tblBCPDocumento_tblDocumento");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblBcpdocumento)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tblBCPDocumento_tblBIAProceso");
            });

            modelBuilder.Entity<TblBcpreanudacionPersonaClave>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBcp, e.IdPersona });

                entity.ToTable("tblBCPReanudacionPersonaClave");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdPersonaClavePrincipal })
                    .HasName("IX_FK_tblPersona_tblReanudacionPersonaClave_FK1");

                entity.Property(e => e.IdDocumentoBcp).HasColumnName("IdDocumentoBCP");

                entity.Property(e => e.IdPersona).ValueGeneratedOnAdd();

                entity.Property(e => e.Actividad)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DireccionHabitacion).IsRequired();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.TelefonoCelular)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.TelefonoHabitacion)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.TelefonoOficina)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBcpreanudacionPersonaClave)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBcp })
                    .HasConstraintName("FK_tblBCPDocumento_tblBCPReanudacionPersonaClave_FK1");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblBcpreanudacionPersonaClave)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPersonaClavePrincipal })
                    .HasConstraintName("FK_tblPersona_tblReanudacionPersonaClave_FK1");
            });

            modelBuilder.Entity<TblBcpreanudacionTarea>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBcp, e.IdBcpreanudacionTarea });

                entity.ToTable("tblBCPReanudacionTarea");

                entity.Property(e => e.IdDocumentoBcp).HasColumnName("IdDocumentoBCP");

                entity.Property(e => e.IdBcpreanudacionTarea)
                    .HasColumnName("IdBCPReanudacionTarea")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBcpreanudacionTarea)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBcp })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBCPDocumento_tblBCPReanudacionTarea_FK1");
            });

            modelBuilder.Entity<TblBcpreanudacionTareaActividad>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBcp, e.IdBcpreanudacionTarea, e.IdBcpreanudacionTareaActividad });

                entity.ToTable("tblBCPReanudacionTareaActividad");

                entity.Property(e => e.IdDocumentoBcp).HasColumnName("IdDocumentoBCP");

                entity.Property(e => e.IdBcpreanudacionTarea).HasColumnName("IdBCPReanudacionTarea");

                entity.Property(e => e.IdBcpreanudacionTareaActividad)
                    .HasColumnName("IdBCPReanudacionTareaActividad")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).IsRequired();

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBcpreanudacionTareaActividad)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBcp, d.IdBcpreanudacionTarea })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBCPReanudacionTarea_tblBCPReanudacionTareaActividad_FK1");
            });

            modelBuilder.Entity<TblBcprecuperacionPersonaClave>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBcp, e.IdPersona });

                entity.ToTable("tblBCPRecuperacionPersonaClave");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdPersonaClavePrincipal })
                    .HasName("IX_FK_tblPersona_tblBCPRecuperacionPersonaClave_FK1");

                entity.Property(e => e.IdDocumentoBcp).HasColumnName("IdDocumentoBCP");

                entity.Property(e => e.IdPersona).ValueGeneratedOnAdd();

                entity.Property(e => e.Actividad)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DireccionHabitacion).IsRequired();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.TelefonoCelular)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.TelefonoHabitacion)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.TelefonoOficina)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBcprecuperacionPersonaClave)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBcp })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBCPDocumento_tblBCPRecuperacionPersonaClave_FK1");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblBcprecuperacionPersonaClave)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPersonaClavePrincipal })
                    .HasConstraintName("FK_tblPersona_tblBCPRecuperacionPersonaClave_FK1");
            });

            modelBuilder.Entity<TblBcprecuperacionRecurso>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBcp, e.IdRecuperacionRecurso });

                entity.ToTable("tblBCPRecuperacionRecurso");

                entity.Property(e => e.IdDocumentoBcp).HasColumnName("IdDocumentoBCP");

                entity.Property(e => e.IdRecuperacionRecurso).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBcprecuperacionRecurso)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBcp })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBCPDocumento_tblBCPRecuperacionRecurso_FK1");
            });

            modelBuilder.Entity<TblBcprespuestaAccion>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBcp, e.IdBcprespuestaAccion });

                entity.ToTable("tblBCPRespuestaAccion");

                entity.Property(e => e.IdDocumentoBcp).HasColumnName("IdDocumentoBCP");

                entity.Property(e => e.IdBcprespuestaAccion)
                    .HasColumnName("IdBCPRespuestaAccion")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NombreEscala)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBcprespuestaAccion)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBcp })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBCPRespuestaAccion_tblBCPDocumento");
            });

            modelBuilder.Entity<TblBcprespuestaRecurso>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBcp, e.IdRespuestaRecurso });

                entity.ToTable("tblBCPRespuestaRecurso");

                entity.Property(e => e.IdDocumentoBcp).HasColumnName("IdDocumentoBCP");

                entity.Property(e => e.IdRespuestaRecurso).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBcprespuestaRecurso)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBcp })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBCPDocumento_tblBCPRespuestaRecurso_FK1");
            });

            modelBuilder.Entity<TblBcprestauracionEquipo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBcp, e.IdBcprestauracionEquipo });

                entity.ToTable("tblBCPRestauracionEquipo");

                entity.Property(e => e.IdDocumentoBcp).HasColumnName("IdDocumentoBCP");

                entity.Property(e => e.IdBcprestauracionEquipo)
                    .HasColumnName("IdBCPRestauracionEquipo")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBcprestauracionEquipo)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBcp })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBCPDocumento_tblBCPRestauracionEquipo_FK1");
            });

            modelBuilder.Entity<TblBcprestauracionInfraestructura>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBcp, e.IdBcprestauracionInfraestructura });

                entity.ToTable("tblBCPRestauracionInfraestructura");

                entity.Property(e => e.IdDocumentoBcp).HasColumnName("IdDocumentoBCP");

                entity.Property(e => e.IdBcprestauracionInfraestructura)
                    .HasColumnName("IdBCPRestauracionInfraestructura")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBcprestauracionInfraestructura)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBcp })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBCPDocumento_tblBCPRestauracionInfraestructura_FK1");
            });

            modelBuilder.Entity<TblBcprestauracionMobiliario>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBcp, e.IdRestauracionMobiliario });

                entity.ToTable("tblBCPRestauracionMobiliario");

                entity.Property(e => e.IdDocumentoBcp).HasColumnName("IdDocumentoBCP");

                entity.Property(e => e.IdRestauracionMobiliario).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBcprestauracionMobiliario)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBcp })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBCPDocumento_tblBCPRestauracionMobiliario_FK1");
            });

            modelBuilder.Entity<TblBcprestauracionOtro>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBcp, e.IdBcprestauracionOtro });

                entity.ToTable("tblBCPRestauracionOtro");

                entity.Property(e => e.IdDocumentoBcp).HasColumnName("IdDocumentoBCP");

                entity.Property(e => e.IdBcprestauracionOtro)
                    .HasColumnName("IdBCPRestauracionOtro")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBcprestauracionOtro)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBcp })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBCPDocumento_tblBCPRestauracionOtro_FK1");
            });

            modelBuilder.Entity<TblBiaamenaza>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumento, e.IdProceso, e.IdAmenaza });

                entity.ToTable("tblBIAAmenaza");

                entity.HasIndex(e => new { e.IdEmpresa, e.Control })
                    .HasName("IX_FK_tblBIAAmenaza_tblControlRiesgo");

                entity.HasIndex(e => new { e.IdEmpresa, e.Estado })
                    .HasName("IX_FK_tblBIAAmenaza_tblEstadoRiesgo");

                entity.HasIndex(e => new { e.IdEmpresa, e.Fuente })
                    .HasName("IX_FK_tblBIAAmenaza_tblFuenteRiesgo");

                entity.HasIndex(e => new { e.IdEmpresa, e.Impacto })
                    .HasName("IX_FK_tblBIAAmenaza_tblImpactoRiesgo");

                entity.HasIndex(e => new { e.IdEmpresa, e.Probabilidad })
                    .HasName("IX_FK_tblBIAAmenaza_tblProbabilidadRiesgo");

                entity.HasIndex(e => new { e.IdEmpresa, e.Severidad })
                    .HasName("IX_FK_tblBIAAmenaza_tblSeveridadRiesgo");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdDocumento, e.IdTipoDocumento })
                    .HasName("IX_FK_tblBIAAmenaza_tblDocumento");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso })
                    .HasName("IX_FK_tblBIAAmenaza_tblBIAProceso");

                entity.Property(e => e.IdAmenaza).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).IsRequired();

                entity.Property(e => e.Fuente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.HasOne(d => d.TblControlRiesgo)
                    .WithMany(p => p.TblBiaamenaza)
                    .HasForeignKey(d => new { d.IdEmpresa, d.Control })
                    .HasConstraintName("FK_tblBIAAmenaza_tblControlRiesgo");

                entity.HasOne(d => d.TblEstadoRiesgo)
                    .WithMany(p => p.TblBiaamenaza)
                    .HasForeignKey(d => new { d.IdEmpresa, d.Estado })
                    .HasConstraintName("FK_tblBIAAmenaza_tblEstadoRiesgo");

                entity.HasOne(d => d.TblFuenteRiesgo)
                    .WithMany(p => p.TblBiaamenaza)
                    .HasForeignKey(d => new { d.IdEmpresa, d.Fuente })
                    .HasConstraintName("FK_tblBIAAmenaza_tblFuenteRiesgo");

                entity.HasOne(d => d.I)
                    .WithMany(p => p.TblBiaamenaza)
                    .HasForeignKey(d => new { d.IdEmpresa, d.Impacto })
                    .HasConstraintName("FK_tblBIAAmenaza_tblImpactoRiesgo");

                entity.HasOne(d => d.TblProbabilidadRiesgo)
                    .WithMany(p => p.TblBiaamenaza)
                    .HasForeignKey(d => new { d.IdEmpresa, d.Probabilidad })
                    .HasConstraintName("FK_tblBIAAmenaza_tblProbabilidadRiesgo");

                entity.HasOne(d => d.TblSeveridadRiesgo)
                    .WithMany(p => p.TblBiaamenaza)
                    .HasForeignKey(d => new { d.IdEmpresa, d.Severidad })
                    .HasConstraintName("FK_tblBIAAmenaza_tblSeveridadRiesgo");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiaamenaza)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumento, d.IdTipoDocumento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAAmenaza_tblDocumento");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblBiaamenaza)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIAAmenaza_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiaamenazaEvento>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdAmenaza, e.IdAmenazaEvento });

                entity.ToTable("tblBIAAmenazaEvento");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdAmenazaEvento).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre).IsRequired();
            });

            modelBuilder.Entity<TblBiaaplicacion>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdAplicacion });

                entity.ToTable("tblBIAAplicacion");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdAplicacion).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre).IsRequired();

                entity.Property(e => e.Usuario).IsRequired();

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiaaplicacion)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIAAplicacion_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiacadenaServicio>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdCadenaServicio });

                entity.ToTable("tblBIACadenaServicio");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblBiacadenaServicio)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIACadenaServicio_tblEmpresa");
            });

            modelBuilder.Entity<TblBiaclienteProceso>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdClienteProceso });

                entity.ToTable("tblBIAClienteProceso");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdClienteProceso).ValueGeneratedOnAdd();

                entity.Property(e => e.Proceso).IsRequired();

                entity.Property(e => e.Producto).IsRequired();

                entity.Property(e => e.Responsable).IsRequired();

                entity.Property(e => e.Unidad).IsRequired();

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiaclienteProceso)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIAClienteProducto_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiacomentario>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdComentario });

                entity.ToTable("tblBIAComentario");

                entity.Property(e => e.IdComentario).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).IsRequired();

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiacomentario)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAComentario_tblBIADocumento");
            });

            modelBuilder.Entity<TblBiadocumentacion>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdDocumento });

                entity.ToTable("tblBIADocumentacion");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdDocumento).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre).IsRequired();

                entity.Property(e => e.Ubicacion).IsRequired();

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiadocumentacion)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIADocumentacion_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiadocumento>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia });

                entity.ToTable("tblBIADocumento");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdUnidadOrganizativa })
                    .HasName("IX_FK_tblBIADocumento_tblUnidadOrganizativa");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdDocumento, e.IdTipoDocumento })
                    .HasName("IX_FK_tblDocumento_tblBIADocumento");

                entity.Property(e => e.IdDocumentoBia)
                    .HasColumnName("IdDocumentoBIA")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblBiadocumento)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblBIADocumento_FK1");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiadocumento)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdUnidadOrganizativa })
                    .HasConstraintName("FK_tblBIADocumento_tblUnidadOrganizativa");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblBiadocumento)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumento, d.IdTipoDocumento })
                    .HasConstraintName("FK_tblDocumento_tblBIADocumento");
            });

            modelBuilder.Entity<TblBiaentrada>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdEntrada });

                entity.ToTable("tblBIAEntrada");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdEntrada).ValueGeneratedOnAdd();

                entity.Property(e => e.Evento).IsRequired();

                entity.Property(e => e.Responsable).IsRequired();

                entity.Property(e => e.Unidad).IsRequired();

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiaentrada)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIAEntrada_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiaeventoControl>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdAmenaza, e.IdAmenazaEvento, e.IdEventoControl });

                entity.ToTable("tblBIAEventoControl");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdEventoControl).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).IsRequired();

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiaeventoControl)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso, d.IdAmenaza, d.IdAmenazaEvento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAEventoControl_tblBIAAmenazaEvento");
            });

            modelBuilder.Entity<TblBiaeventoRiesgo>(entity =>
            {
                entity.HasKey(e => new { e.IdEventoRiesgo, e.IdEmpresa });

                entity.ToTable("tblBIAEventoRiesgo");

                entity.Property(e => e.IdEventoRiesgo).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblBiagranImpacto>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdGranImpacto, e.IdMes });

                entity.ToTable("tblBIAGranImpacto");

                entity.HasIndex(e => e.IdMes)
                    .HasName("IX_FK_tblBIAGranImpacto_tblMes");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdGranImpacto).ValueGeneratedOnAdd();

                entity.Property(e => e.Explicacion).IsRequired();

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.IdMesNavigation)
                    .WithMany(p => p.TblBiagranImpacto)
                    .HasForeignKey(d => d.IdMes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAGranImpacto_tblMes");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiagranImpacto)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIAGranImpacto_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiaimpactoFinanciero>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdImpactoFinanciero });

                entity.ToTable("tblBIAImpactoFinanciero");

                entity.HasIndex(e => e.IdTipoFrecuencia)
                    .HasName("IX_FK_tblBIAImpactoFinanciero_tblTipoFrecuencia");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdEscala })
                    .HasName("IX_FK_tblBIAImpactoFinanciero_tblEscala");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdImpactoFinanciero).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).IsRequired();

                entity.Property(e => e.Impacto).IsRequired();

                entity.Property(e => e.UnidadTiempo).HasMaxLength(450);

                entity.HasOne(d => d.IdTipoFrecuenciaNavigation)
                    .WithMany(p => p.TblBiaimpactoFinanciero)
                    .HasForeignKey(d => d.IdTipoFrecuencia)
                    .HasConstraintName("FK_tblBIAImpactoFinanciero_tblTipoFrecuencia");

                entity.HasOne(d => d.IdE)
                    .WithMany(p => p.TblBiaimpactoFinanciero)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdEscala })
                    .HasConstraintName("FK_tblBIAImpactoFinanciero_tblEscala");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiaimpactoFinanciero)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIAImpactoFinanciero_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiaimpactoOperacional>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdImpactoOperacional });

                entity.ToTable("tblBIAImpactoOperacional");

                entity.HasIndex(e => e.IdTipoFrecuencia)
                    .HasName("IX_FK_tblBIAImpactoOperacional_tblTipoFrecuencia");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdEscala })
                    .HasName("IX_FK_tblBIAImpactoOperacional_tblEscala");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdImpactoOperacional).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).IsRequired();

                entity.Property(e => e.ImpactoOperacional)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.UnidadTiempo).HasMaxLength(450);

                entity.HasOne(d => d.IdTipoFrecuenciaNavigation)
                    .WithMany(p => p.TblBiaimpactoOperacional)
                    .HasForeignKey(d => d.IdTipoFrecuencia)
                    .HasConstraintName("FK_tblBIAImpactoOperacional_tblTipoFrecuencia");

                entity.HasOne(d => d.IdE)
                    .WithMany(p => p.TblBiaimpactoOperacional)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdEscala })
                    .HasConstraintName("FK_tblBIAImpactoOperacional_tblEscala");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiaimpactoOperacional)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIAImpactoOperacional_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiainterdependencia>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdInterdependencia });

                entity.ToTable("tblBIAInterdependencia");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdInterdependencia).ValueGeneratedOnAdd();

                entity.Property(e => e.Contacto).IsRequired();

                entity.Property(e => e.Organizacion).IsRequired();

                entity.Property(e => e.Servicio).IsRequired();

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiainterdependencia)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIAInterdependencia_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiamtd>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdMtd });

                entity.ToTable("tblBIAMTD");

                entity.HasIndex(e => e.IdTipoFrecuencia)
                    .HasName("IX_FK_tblBIAMTD_tblTipoFrecuencia");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdEscala })
                    .HasName("IX_FK_tblBIAMTD_tblEscala");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdMtd)
                    .HasColumnName("IdMTD")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdTipoFrecuenciaNavigation)
                    .WithMany(p => p.TblBiamtd)
                    .HasForeignKey(d => d.IdTipoFrecuencia)
                    .HasConstraintName("FK_tblBIAMTD_tblTipoFrecuencia");

                entity.HasOne(d => d.IdE)
                    .WithMany(p => p.TblBiamtd)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdEscala })
                    .HasConstraintName("FK_tblBIAMTD_tblEscala");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiamtd)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIAMTD_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiapersonaClave>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdPersonaClave });

                entity.ToTable("tblBIAPersonaClave");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdDocumento, e.IdTipoDocumento })
                    .HasName("IX_FK_tblBIAPersonaClave_tblDocumento");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdDocumento, e.IdTipoDocumento, e.IdPersonaClave })
                    .HasName("IX_FK_tblBIAPersonaClave_tblDocumentoPersonaClave");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiapersonaClave)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumento, d.IdTipoDocumento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAPersonaClave_tblDocumento");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblBiapersonaClave)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIAPersonaClave_tblBIAProceso");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TblBiapersonaClave)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumento, d.IdTipoDocumento, d.IdPersonaClave })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAPersonaClave_tblDocumentoPersonaClave");
            });

            modelBuilder.Entity<TblBiapersonaRespaldoProceso>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdPersona, e.IdProceso });

                entity.ToTable("tblBIAPersonaRespaldoProceso");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdPersona })
                    .HasName("IX_FK_tblBIAPersonaRespaldoProceso_tblPersona");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso })
                    .HasName("IX_FK_tblBIAPersonaRespaldoProceso_tblBIAProceso");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiapersonaRespaldoProceso)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPersona })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAPersonaRespaldoProceso_tblPersona");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblBiapersonaRespaldoProceso)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIAPersonaRespaldoProceso_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiaproceso>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso });

                entity.ToTable("tblBIAProceso");

                entity.HasIndex(e => e.IdEstadoProceso)
                    .HasName("IX_FK_tblBIAProceso_tblEstadoProceso");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdUnidadOrganizativa })
                    .HasName("IX_FK_tblBIAProceso_tblUnidadOrganizativa");

                entity.Property(e => e.IdProceso).ValueGeneratedOnAdd();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimoEstatus).HasColumnType("datetime");

                entity.Property(e => e.Nombre).HasMaxLength(1500);

                entity.HasOne(d => d.IdEstadoProcesoNavigation)
                    .WithMany(p => p.TblBiaproceso)
                    .HasForeignKey(d => d.IdEstadoProceso)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tblBIAProceso_tblEstadoProceso");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiaproceso)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia })
                    .HasConstraintName("FK_tblBIAProceso_tblBIADocumento");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblBiaproceso)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdUnidadOrganizativa })
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tblBIAProceso_tblUnidadOrganizativa");
            });

            modelBuilder.Entity<TblBiaprocesoAlterno>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdProcesoAlterno });

                entity.ToTable("tblBIAProcesoAlterno");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdProcesoAlterno).ValueGeneratedOnAdd();

                entity.Property(e => e.ProcesoAlterno).IsRequired();

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiaprocesoAlterno)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIAProcesoAlterno_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiaproveedor>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdProveedor });

                entity.ToTable("tblBIAProveedor");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdProveedor).ValueGeneratedOnAdd();

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Organizacion)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Servicio)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiaproveedor)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIAProveedor_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiarespaldoPrimario>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdRespaldo });

                entity.ToTable("tblBIARespaldoPrimario");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdRespaldo).ValueGeneratedOnAdd();

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiarespaldoPrimario)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIARespaldoPrimario_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiarespaldoSecundario>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdRespaldo });

                entity.ToTable("tblBIARespaldoSecundario");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdRespaldo).ValueGeneratedOnAdd();

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiarespaldoSecundario)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIARespaldoSecundario_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiarpo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdRpo });

                entity.ToTable("tblBIARPO");

                entity.HasIndex(e => e.IdTipoFrecuencia)
                    .HasName("IX_FK_tblBIARPO_tblTipoFrecuencia");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdEscala })
                    .HasName("IX_FK_tblBIARPO_tblEscala");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdRpo)
                    .HasColumnName("IdRPO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.IdTipoFrecuenciaNavigation)
                    .WithMany(p => p.TblBiarpo)
                    .HasForeignKey(d => d.IdTipoFrecuencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIARPO_tblTipoFrecuencia");

                entity.HasOne(d => d.IdE)
                    .WithMany(p => p.TblBiarpo)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdEscala })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIARPO_tblEscala");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiarpo)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIARPO_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiarto>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdRto });

                entity.ToTable("tblBIARTO");

                entity.HasIndex(e => e.IdTipoFrecuencia)
                    .HasName("IX_FK_tblBIARTO_tblTipoFrecuencia");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdEscala })
                    .HasName("IX_FK_tblBIARTO_tblEscala");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdRto)
                    .HasColumnName("IdRTO")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Observacion).IsRequired();

                entity.HasOne(d => d.IdTipoFrecuenciaNavigation)
                    .WithMany(p => p.TblBiarto)
                    .HasForeignKey(d => d.IdTipoFrecuencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIARTO_tblTipoFrecuencia");

                entity.HasOne(d => d.IdE)
                    .WithMany(p => p.TblBiarto)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdEscala })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIARTO_tblEscala");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiarto)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIARTO_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiaunidadTrabajo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdUnidadTrabajo });

                entity.ToTable("tblBIAUnidadTrabajo");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdUnidadOrganizativa })
                    .HasName("IX_FK_tblBIAUnidadTrabajo_tblUnidadOrganizativa");

                entity.Property(e => e.IdUnidadTrabajo).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblBiaunidadTrabajo)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAUnidadTrabajo_tblEmpresa");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiaunidadTrabajo)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdUnidadOrganizativa })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAUnidadTrabajo_tblUnidadOrganizativa");
            });

            modelBuilder.Entity<TblBiaunidadTrabajoPersonas>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdUnidadTrabajo, e.IdUnidadTrabajoProceso, e.IdUnidadPersona, e.IdClienteProceso });

                entity.ToTable("tblBIAUnidadTrabajoPersonas");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdClienteProceso })
                    .HasName("IX_FK_tblBIAUnidadTrabajoPersonas_tblBIAClienteProceso");

                entity.Property(e => e.IdUnidadPersona).ValueGeneratedOnAdd();

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiaunidadTrabajoPersonas)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdUnidadTrabajo, d.IdUnidadTrabajoProceso })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAUnidadTrabajoPersonas_tblBIAUnidadTrabajoProceso");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblBiaunidadTrabajoPersonas)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso, d.IdClienteProceso })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAUnidadTrabajoPersonas_tblBIAClienteProceso");
            });

            modelBuilder.Entity<TblBiaunidadTrabajoProceso>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdUnidadTrabajo, e.IdUnidadTrabajoProceso });

                entity.ToTable("tblBIAUnidadTrabajoProceso");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso })
                    .HasName("IX_FK_tblBIAUnidadTrabajoProceso_tblBIAProceso");

                entity.Property(e => e.IdUnidadTrabajoProceso).ValueGeneratedOnAdd();

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiaunidadTrabajoProceso)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdUnidadTrabajo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAUnidadTrabajoProceso_tblBIAUnidadTrabajo");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblBiaunidadTrabajoProceso)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIAUnidadTrabajoProceso_tblBIAProceso");
            });

            modelBuilder.Entity<TblBiawrt>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumentoBia, e.IdProceso, e.IdWrt });

                entity.ToTable("tblBIAWRT");

                entity.HasIndex(e => e.IdTipoFrecuencia)
                    .HasName("IX_FK_tblBIAWRT_tblTipoFrecuencia");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdEscala })
                    .HasName("IX_FK_tblBIAWRT_tblEscala");

                entity.Property(e => e.IdDocumentoBia).HasColumnName("IdDocumentoBIA");

                entity.Property(e => e.IdWrt)
                    .HasColumnName("IdWRT")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdTipoFrecuenciaNavigation)
                    .WithMany(p => p.TblBiawrt)
                    .HasForeignKey(d => d.IdTipoFrecuencia)
                    .HasConstraintName("FK_tblBIAWRT_tblTipoFrecuencia");

                entity.HasOne(d => d.IdE)
                    .WithMany(p => p.TblBiawrt)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdEscala })
                    .HasConstraintName("FK_tblBIAWRT_tblEscala");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblBiawrt)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumentoBia, d.IdProceso })
                    .HasConstraintName("FK_tblBIAWRT_tblBIAProceso");
            });

            modelBuilder.Entity<TblCargo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdCargo });

                entity.ToTable("tblCargo");

                entity.Property(e => e.IdCargo).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblCargo)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblCargo_FK1");
            });

            modelBuilder.Entity<TblCiudad>(entity =>
            {
                entity.HasKey(e => new { e.IdPais, e.IdEstado, e.IdCiudad });

                entity.ToTable("tblCiudad");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.TblCiudad)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCiudad_tblPais");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblCiudad)
                    .HasForeignKey(d => new { d.IdPais, d.IdEstado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCiudad_tblEstado");
            });

            modelBuilder.Entity<TblControlRiesgo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdControl });

                entity.ToTable("tblControlRiesgo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TblCriticidad>(entity =>
            {
                entity.HasKey(e => new { e.FechaAplicacion, e.IdEmpresa, e.IdTipoEscala });

                entity.ToTable("tblCriticidad");

                entity.HasIndex(e => e.IdEmpresa)
                    .HasName("IX_FK_tblCriticidad_tblEmpresa");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdTipoEscala })
                    .HasName("IX_FK_tblCriticidad_tblTipoEscala");

                entity.Property(e => e.FechaAplicacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblCriticidad)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCriticidad_tblEmpresa");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblCriticidad)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdTipoEscala })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCriticidad_tblTipoEscala");
            });

            modelBuilder.Entity<TblCulturaCiudad>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdPais, e.IdEstado, e.IdCiudad });

                entity.ToTable("tblCultura_Ciudad");

                entity.HasIndex(e => new { e.IdPais, e.IdEstado, e.IdCiudad })
                    .HasName("IX_FK_tblCulture_Ciudad_tblCiudad");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).HasMaxLength(250);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblCulturaCiudad)
                    .HasForeignKey(d => new { d.IdPais, d.IdEstado, d.IdCiudad })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCulture_Ciudad_tblCiudad");
            });

            modelBuilder.Entity<TblCulturaEstado>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdPais, e.IdEstado });

                entity.ToTable("tblCultura_Estado");

                entity.HasIndex(e => new { e.IdPais, e.IdEstado })
                    .HasName("IX_FK_tblCultura_Estado_tblEstado");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).HasMaxLength(250);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblCulturaEstado)
                    .HasForeignKey(d => new { d.IdPais, d.IdEstado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_Estado_tblEstado");
            });

            modelBuilder.Entity<TblCulturaEstadoDocumento>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdEstadoDocumento });

                entity.ToTable("tblCultura_EstadoDocumento");

                entity.HasIndex(e => e.IdEstadoDocumento)
                    .HasName("IX_FK_tblCultura_EstadoDocumento_tblEstadoDocumento");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.IdEstadoDocumentoNavigation)
                    .WithMany(p => p.TblCulturaEstadoDocumento)
                    .HasForeignKey(d => d.IdEstadoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_EstadoDocumento_tblEstadoDocumento");
            });

            modelBuilder.Entity<TblCulturaEstadoEmpresa>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdEstadoEmpresa });

                entity.ToTable("tblCultura_EstadoEmpresa");

                entity.HasIndex(e => e.IdEstadoEmpresa)
                    .HasName("IX_FK_tblCultura_EstadoEmpresa_tblEstadoEmpresa");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdEstadoEmpresaNavigation)
                    .WithMany(p => p.TblCulturaEstadoEmpresa)
                    .HasForeignKey(d => d.IdEstadoEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_EstadoEmpresa_tblEstadoEmpresa");
            });

            modelBuilder.Entity<TblCulturaEstadoProceso>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdEstadoProceso });

                entity.ToTable("tblCultura_EstadoProceso");

                entity.HasIndex(e => e.IdEstadoProceso)
                    .HasName("IX_FK_tblCultura_EstadoProceso_tblEstadoProceso");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.IdEstadoProcesoNavigation)
                    .WithMany(p => p.TblCulturaEstadoProceso)
                    .HasForeignKey(d => d.IdEstadoProceso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_EstadoProceso_tblEstadoProceso");
            });

            modelBuilder.Entity<TblCulturaEstadoUsuario>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdEstadoUsuario });

                entity.ToTable("tblCultura_EstadoUsuario");

                entity.HasIndex(e => e.IdEstadoUsuario)
                    .HasName("IX_FK_tblCultura_EstadoUsuario_tblEstadoUsuario");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.IdEstadoUsuarioNavigation)
                    .WithMany(p => p.TblCulturaEstadoUsuario)
                    .HasForeignKey(d => d.IdEstadoUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_EstadoUsuario_tblEstadoUsuario");
            });

            modelBuilder.Entity<TblCulturaMes>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdMes });

                entity.ToTable("tblCultura_Mes");

                entity.HasIndex(e => e.IdMes)
                    .HasName("IX_FK_tblCultura_Mes_tblMes");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.IdMesNavigation)
                    .WithMany(p => p.TblCulturaMes)
                    .HasForeignKey(d => d.IdMes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_Mes_tblMes");
            });

            modelBuilder.Entity<TblCulturaNivelImpacto>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdNivelImpacto });

                entity.ToTable("tblCultura_NivelImpacto");

                entity.HasIndex(e => e.IdNivelImpacto)
                    .HasName("IX_FK_tblCultura_NivelImpacto_tblNivelImpacto");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.IdNivelImpactoNavigation)
                    .WithMany(p => p.TblCulturaNivelImpacto)
                    .HasForeignKey(d => d.IdNivelImpacto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_NivelImpacto_tblNivelImpacto");
            });

            modelBuilder.Entity<TblCulturaNivelUsuario>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdNivelUsuario });

                entity.ToTable("tblCultura_NivelUsuario");

                entity.HasIndex(e => e.IdNivelUsuario)
                    .HasName("IX_FK_tblCulture_NivelUsuario_tblNivelUsuario");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(450);

                entity.HasOne(d => d.IdNivelUsuarioNavigation)
                    .WithMany(p => p.TblCulturaNivelUsuario)
                    .HasForeignKey(d => d.IdNivelUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCulture_NivelUsuario_tblNivelUsuario");
            });

            modelBuilder.Entity<TblCulturaPais>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdPais });

                entity.ToTable("tblCultura_Pais");

                entity.HasIndex(e => e.IdPais)
                    .HasName("IX_FK_tblCulture_Pais_tblPais");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Nombre).HasMaxLength(250);

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.TblCulturaPais)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCulture_Pais_tblPais");
            });

            modelBuilder.Entity<TblCulturaPbepruebaEstatus>(entity =>
            {
                entity.HasKey(e => new { e.Cultura, e.IdEstatus });

                entity.ToTable("tblCultura_PBEPruebaEstatus");

                entity.HasIndex(e => e.IdEstatus)
                    .HasName("IX_FK_tblCultura_PBEPruebaEjecucionEstatus_tblPBEPruebaEjecucionEstatus");

                entity.Property(e => e.Cultura)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.TblCulturaPbepruebaEstatus)
                    .HasForeignKey(d => d.IdEstatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_PBEPruebaEjecucionEstatus_tblPBEPruebaEjecucionEstatus");
            });

            modelBuilder.Entity<TblCulturaPlanTrabajoEstatus>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdEstatusActividad });

                entity.ToTable("tblCultura_PlanTrabajoEstatus");

                entity.HasIndex(e => e.IdEstatusActividad)
                    .HasName("IX_FK_tblCultura_PlanTrabajoEstatus_tblPlanTrabajoEstatus");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(450);

                entity.HasOne(d => d.IdEstatusActividadNavigation)
                    .WithMany(p => p.TblCulturaPlanTrabajoEstatus)
                    .HasForeignKey(d => d.IdEstatusActividad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_PlanTrabajoEstatus_tblPlanTrabajoEstatus");
            });

            modelBuilder.Entity<TblCulturaPmtprogramacionTipoActualizacion>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdTipoActualizacion });

                entity.ToTable("tblCultura_PMTProgramacionTipoActualizacion");

                entity.HasIndex(e => e.IdTipoActualizacion)
                    .HasName("IX_FK_tblCultura_PMTProgramacionTipoActualizacion_tblPMTProgramacionTipoActualizacion");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.IdTipoActualizacionNavigation)
                    .WithMany(p => p.TblCulturaPmtprogramacionTipoActualizacion)
                    .HasForeignKey(d => d.IdTipoActualizacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_PMTProgramacionTipoActualizacion_tblPMTProgramacionTipoActualizacion");
            });

            modelBuilder.Entity<TblCulturaPmtprogramacionTipoNotificacion>(entity =>
            {
                entity.HasKey(e => new { e.Cultura, e.IdTipoNotificacion });

                entity.ToTable("tblCultura_PMTProgramacionTipoNotificacion");

                entity.HasIndex(e => e.IdTipoNotificacion)
                    .HasName("IX_FK_tblCultura_PMTProgramacionTipoNotificacion_tblPMTProgramacionTipoNotificacion");

                entity.Property(e => e.Cultura)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdTipoNotificacionNavigation)
                    .WithMany(p => p.TblCulturaPmtprogramacionTipoNotificacion)
                    .HasForeignKey(d => d.IdTipoNotificacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_PMTProgramacionTipoNotificacion_tblPMTProgramacionTipoNotificacion");
            });

            modelBuilder.Entity<TblCulturaTipoCorreo>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdTipoCorreo });

                entity.ToTable("tblCultura_TipoCorreo");

                entity.HasIndex(e => e.IdTipoCorreo)
                    .HasName("IX_FK_tblCultura_TipoCorreo_tblTipoCorreo");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.HasOne(d => d.IdTipoCorreoNavigation)
                    .WithMany(p => p.TblCulturaTipoCorreo)
                    .HasForeignKey(d => d.IdTipoCorreo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoCorreo_tblTipoCorreo");
            });

            modelBuilder.Entity<TblCulturaTipoDireccion>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdTipoDireccion });

                entity.ToTable("tblCultura_TipoDireccion");

                entity.HasIndex(e => e.IdTipoDireccion)
                    .HasName("IX_FK_tblCultura_TipoDireccion_tblTipoDireccion");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.IdTipoDireccionNavigation)
                    .WithMany(p => p.TblCulturaTipoDireccion)
                    .HasForeignKey(d => d.IdTipoDireccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoDireccion_tblTipoDireccion");
            });

            modelBuilder.Entity<TblCulturaTipoFrecuencia>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdTipoFrecuencia });

                entity.ToTable("tblCultura_TipoFrecuencia");

                entity.HasIndex(e => e.IdTipoFrecuencia)
                    .HasName("IX_FK_tblCultura_TipoFrecuencia_tblTipoFrecuencia");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(450);

                entity.HasOne(d => d.IdTipoFrecuenciaNavigation)
                    .WithMany(p => p.TblCulturaTipoFrecuencia)
                    .HasForeignKey(d => d.IdTipoFrecuencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoFrecuencia_tblTipoFrecuencia");
            });

            modelBuilder.Entity<TblCulturaTipoImpacto>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdTipoImpacto });

                entity.ToTable("tblCultura_TipoImpacto");

                entity.HasIndex(e => e.IdTipoImpacto)
                    .HasName("IX_FK_tblCultura_TipoImpacto_tblTipoImpacto");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.IdTipoImpactoNavigation)
                    .WithMany(p => p.TblCulturaTipoImpacto)
                    .HasForeignKey(d => d.IdTipoImpacto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoImpacto_tblTipoImpacto");
            });

            modelBuilder.Entity<TblCulturaTipoInterdependencia>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdTipoInterdependencia });

                entity.ToTable("tblCultura_TipoInterdependencia");

                entity.HasIndex(e => e.IdTipoInterdependencia)
                    .HasName("IX_FK_tblCultura_TipoInterdependencia_tblTipoInterdependencia");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.IdTipoInterdependenciaNavigation)
                    .WithMany(p => p.TblCulturaTipoInterdependencia)
                    .HasForeignKey(d => d.IdTipoInterdependencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoInterdependencia_tblTipoInterdependencia");
            });

            modelBuilder.Entity<TblCulturaTipoRespaldo>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdTipoRespaldo });

                entity.ToTable("tblCultura_TipoRespaldo");

                entity.HasIndex(e => e.IdTipoRespaldo)
                    .HasName("IX_FK_tblCultura_TipoRespaldo_tblTipoRespaldo");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.IdTipoRespaldoNavigation)
                    .WithMany(p => p.TblCulturaTipoRespaldo)
                    .HasForeignKey(d => d.IdTipoRespaldo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoRespaldo_tblTipoRespaldo");
            });

            modelBuilder.Entity<TblCulturaTipoResultadoPrueba>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdTipoResultadoPrueba });

                entity.ToTable("tblCultura_TipoResultadoPrueba");

                entity.HasIndex(e => e.IdTipoResultadoPrueba)
                    .HasName("IX_FK_tblCultura_TipoResultadoPrueba_tblTipoResultadoPrueba");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.IdTipoResultadoPruebaNavigation)
                    .WithMany(p => p.TblCulturaTipoResultadoPrueba)
                    .HasForeignKey(d => d.IdTipoResultadoPrueba)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoResultadoPrueba_tblTipoResultadoPrueba");
            });

            modelBuilder.Entity<TblCulturaTipoTablaContenido>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdTipoTablaContenido });

                entity.ToTable("tblCultura_TipoTablaContenido");

                entity.HasIndex(e => e.IdTipoTablaContenido)
                    .HasName("IX_FK_tblCultura_TipoTablaContenido_tblTipoTablaContenido");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.IdTipoTablaContenidoNavigation)
                    .WithMany(p => p.TblCulturaTipoTablaContenido)
                    .HasForeignKey(d => d.IdTipoTablaContenido)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoTablaContenido_tblTipoTablaContenido");
            });

            modelBuilder.Entity<TblCulturaTipoTelefono>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdTipoTelefono });

                entity.ToTable("tblCultura_TipoTelefono");

                entity.HasIndex(e => e.IdTipoTelefono)
                    .HasName("IX_FK_tblCultura_TipoTelefono_tblTipoTelefono");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.IdTipoTelefonoNavigation)
                    .WithMany(p => p.TblCulturaTipoTelefono)
                    .HasForeignKey(d => d.IdTipoTelefono)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoTelefono_tblTipoTelefono");
            });

            modelBuilder.Entity<TblCulturaTipoUbicacionInformacion>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdTipoUbicacionInformacion });

                entity.ToTable("tblCultura_TipoUbicacionInformacion");

                entity.HasIndex(e => e.IdTipoUbicacionInformacion)
                    .HasName("IX_FK_tblCultura_TipoUbicacionInformacion_tblTipoUbicacionInformacion");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.HasOne(d => d.IdTipoUbicacionInformacionNavigation)
                    .WithMany(p => p.TblCulturaTipoUbicacionInformacion)
                    .HasForeignKey(d => d.IdTipoUbicacionInformacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCultura_TipoUbicacionInformacion_tblTipoUbicacionInformacion");
            });

            modelBuilder.Entity<TblCultureFuenteIncidente>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdFuenteIncidente });

                entity.ToTable("tblCulture_FuenteIncidente");

                entity.HasIndex(e => e.IdFuenteIncidente)
                    .HasName("IX_FK_tblCulture_FuenteIncidente_tblFuenteIncidente");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.HasOne(d => d.IdFuenteIncidenteNavigation)
                    .WithMany(p => p.TblCultureFuenteIncidente)
                    .HasForeignKey(d => d.IdFuenteIncidente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCulture_FuenteIncidente_tblFuenteIncidente");
            });

            modelBuilder.Entity<TblCultureNaturalezaIncidente>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdNaturalezaIncidente });

                entity.ToTable("tblCulture_NaturalezaIncidente");

                entity.HasIndex(e => e.IdNaturalezaIncidente)
                    .HasName("IX_FK_tblCulture_NaturalezaIncidente_tblNaturalezaIncidente");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.HasOne(d => d.IdNaturalezaIncidenteNavigation)
                    .WithMany(p => p.TblCultureNaturalezaIncidente)
                    .HasForeignKey(d => d.IdNaturalezaIncidente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCulture_NaturalezaIncidente_tblNaturalezaIncidente");
            });

            modelBuilder.Entity<TblCultureTipoIncidente>(entity =>
            {
                entity.HasKey(e => new { e.Culture, e.IdTipoIncidente });

                entity.ToTable("tblCulture_TipoIncidente");

                entity.HasIndex(e => e.IdTipoIncidente)
                    .HasName("IX_FK_tblCulture_TipoIncidente_tblTipoIncidente");

                entity.Property(e => e.Culture)
                    .HasMaxLength(5)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.HasOne(d => d.IdTipoIncidenteNavigation)
                    .WithMany(p => p.TblCultureTipoIncidente)
                    .HasForeignKey(d => d.IdTipoIncidente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCulture_TipoIncidente_tblTipoIncidente");
            });

            modelBuilder.Entity<TblDispositivo>(entity =>
            {
                entity.HasKey(e => e.IdDispositivo);

                entity.ToTable("tblDispositivo");

                entity.Property(e => e.Fabricante)
                    .HasColumnName("fabricante")
                    .HasMaxLength(500);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fechaRegistro")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdUnicoDispositivo).HasMaxLength(500);

                entity.Property(e => e.Modelo)
                    .HasColumnName("modelo")
                    .HasMaxLength(500);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(500);

                entity.Property(e => e.Plataforma)
                    .HasColumnName("plataforma")
                    .HasMaxLength(500);

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(50);

                entity.Property(e => e.Token).HasColumnName("token");

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<TblDispositivo1>(entity =>
            {
                entity.HasKey(e => e.IdDispositivo);

                entity.ToTable("tblDispositivo1");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("IX_FK_tblDispositivo_tblUsuario");

                entity.Property(e => e.Fabricante).HasMaxLength(500);

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.ImeiDispositivo)
                    .HasColumnName("IMEI_Dispositivo")
                    .HasMaxLength(100);

                entity.Property(e => e.Modelo).HasMaxLength(500);

                entity.Property(e => e.NombreDispositivo).HasMaxLength(500);

                entity.Property(e => e.Plataforma).HasMaxLength(500);

                entity.Property(e => e.TipoDispositivo).HasMaxLength(500);

                entity.Property(e => e.Version).HasMaxLength(500);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.MobileDevices)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDispositivo_tblUsuario");
            });

            modelBuilder.Entity<TblDispositivoConexion>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDispositivo, e.IdUsuario, e.FechaConexion });

                entity.ToTable("tblDispositivoConexion");

                entity.HasIndex(e => e.IdDispositivo)
                    .HasName("IX_FK_tblDispositivoConexion_tblUsuarioDispositivo");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("IX_FK_tblDispositivoConexion_tblUsuario");

                entity.Property(e => e.FechaConexion)
                    .HasColumnName("fechaConexion")
                    .HasColumnType("datetime");

                entity.Property(e => e.DireccionIp)
                    .HasColumnName("DireccionIP")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdDispositivoNavigation)
                    .WithMany(p => p.TblDispositivoConexion)
                    .HasForeignKey(d => d.IdDispositivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDispositivoConexion_tblUsuarioDispositivo");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblDispositivoConexion)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDispositivoConexion_tblEmpresa");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.MobileDeviceConnections)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDispositivoConexion_tblUsuario");
            });

            modelBuilder.Entity<TblDispositivoConexion1>(entity =>
            {
                entity.HasKey(e => new { e.IdDispositivo, e.IdUsuario, e.FechaConexion });

                entity.ToTable("tblDispositivoConexion1");

                entity.HasIndex(e => e.IdEmpresa)
                    .HasName("IX_FK_tblDispositivoConexion_tblEmpresa1");

                entity.Property(e => e.FechaConexion).HasColumnType("datetime");

                entity.Property(e => e.DirecciónIp)
                    .HasColumnName("DirecciónIP")
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdDispositivoNavigation)
                    .WithMany(p => p.TblDispositivoConexion1)
                    .HasForeignKey(d => d.IdDispositivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDispositivoConexion_tblDispositivo");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblDispositivoConexion1)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK_tblDispositivoConexion_tblEmpresa1");
            });

            modelBuilder.Entity<TblDispositivoEnvio>(entity =>
            {
                entity.HasKey(e => new { e.IdDispositivo, e.IdSubModulo });

                entity.ToTable("tblDispositivoEnvio");

                entity.Property(e => e.FechaDescarga).HasColumnType("datetime");

                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

                entity.HasOne(d => d.IdDispositivoNavigation)
                    .WithMany(p => p.TblDispositivoEnvio)
                    .HasForeignKey(d => d.IdDispositivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDispositivoEnvio_tblDispositivo");
            });

            modelBuilder.Entity<TblDispositivoEnvio1>(entity =>
            {
                entity.HasKey(e => new { e.IdDispositivo, e.IdUsuario, e.IdEmpresa, e.IdSubModulo, e.IdUsuarioEnvia, e.FechaEnvio });

                entity.ToTable("tblDispositivoEnvio1");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("IX_FK_tblDispositivoEnvio_tblUsuarioRecibe");

                entity.HasIndex(e => e.IdUsuarioEnvia)
                    .HasName("IX_FK_tblDispositivoEnvio_tblUsuarioEnvia");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdSubModulo })
                    .HasName("IX_FK_tblDispositivoEnvio_tblEmpresaModulo");

                entity.Property(e => e.FechaEnvio).HasColumnType("datetime");

                entity.Property(e => e.FechaDescarga).HasColumnType("datetime");

                entity.HasOne(d => d.IdDispositivoNavigation)
                    .WithMany(p => p.TblDispositivoEnvio1)
                    .HasForeignKey(d => d.IdDispositivo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDispositivoEnvio_tblDispositivo1");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.MobileDeviceReceivesByUserId)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDispositivoEnvio_tblUsuarioRecibe");

                entity.HasOne(d => d.IdUsuarioEnviaNavigation)
                    .WithMany(p => p.MobileDeviceSendsByUserId)
                    .HasForeignKey(d => d.IdUsuarioEnvia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDispositivoEnvio_tblUsuarioEnvia");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblDispositivoEnvio1)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdSubModulo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDispositivoEnvio_tblEmpresaModulo");
            });

            modelBuilder.Entity<TblDocumento>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumento, e.IdTipoDocumento });

                entity.ToTable("tblDocumento");

                entity.HasIndex(e => e.IdEstadoDocumento)
                    .HasName("IX_FK_tblDocumento_tblEstadoDocumento");

                entity.Property(e => e.IdDocumento).ValueGeneratedOnAdd();

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaEstadoDocumento).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimaModificacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblDocumento)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDocumento_tblEmpresa");

                entity.HasOne(d => d.IdEstadoDocumentoNavigation)
                    .WithMany(p => p.TblDocumento)
                    .HasForeignKey(d => d.IdEstadoDocumento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDocumento_tblEstadoDocumento");
            });

            modelBuilder.Entity<TblDocumentoAnexo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumento, e.IdTipoDocumento, e.IdAnexo });

                entity.ToTable("tblDocumentoAnexo");

                entity.Property(e => e.IdAnexo).ValueGeneratedOnAdd();

                entity.Property(e => e.LastWriteTime).HasColumnType("datetime");

                entity.Property(e => e.Nombre).HasMaxLength(500);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblDocumentoAnexo)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumento, d.IdTipoDocumento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDocumentoAnexo_tblDocumento");
            });

            modelBuilder.Entity<TblDocumentoAprobacion>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumento, e.IdTipoDocumento, e.IdAprobacion });

                entity.ToTable("tblDocumentoAprobacion");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdPersona })
                    .HasName("IX_FK_tblDocumentoAprobacion_tblPersona");

                entity.Property(e => e.IdAprobacion).ValueGeneratedOnAdd();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblDocumentoAprobacion)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPersona })
                    .HasConstraintName("FK_tblDocumentoAprobacion_tblPersona");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblDocumentoAprobacion)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumento, d.IdTipoDocumento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAprobacion_tblDocumento");
            });

            modelBuilder.Entity<TblDocumentoCertificacion>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumento, e.IdTipoDocumento, e.IdCertificacion });

                entity.ToTable("tblDocumentoCertificacion");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdPersona })
                    .HasName("IX_FK_tblCertificacion_tblPersona");

                entity.Property(e => e.IdCertificacion).ValueGeneratedOnAdd();

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblDocumentoCertificacion)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPersona })
                    .HasConstraintName("FK_tblCertificacion_tblPersona");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblDocumentoCertificacion)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumento, d.IdTipoDocumento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCertificacion_tblDocumento");
            });

            modelBuilder.Entity<TblDocumentoContenido>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumento, e.IdTipoDocumento, e.IdSubModulo });

                entity.ToTable("tblDocumentoContenido");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdSubModulo })
                    .HasName("IX_FK_tblDocumentoContenido_tblModulo");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblDocumentoContenido)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdSubModulo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDocumentoContenido_tblModulo");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblDocumentoContenido)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumento, d.IdTipoDocumento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDocumentoContenido_tblDocumento");
            });

            modelBuilder.Entity<TblDocumentoEntrevista>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumento, e.IdTipoDocumento, e.IdEntrevista });

                entity.ToTable("tblDocumentoEntrevista");

                entity.Property(e => e.IdEntrevista).ValueGeneratedOnAdd();

                entity.Property(e => e.FechaFinal).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblDocumentoEntrevista)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumento, d.IdTipoDocumento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDocumentoEntrevista_tblDocumento");
            });

            modelBuilder.Entity<TblDocumentoEntrevistaPersona>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumento, e.IdTipoDocumento, e.IdEntrevista, e.IdPersonaEntrevista });

                entity.ToTable("tblDocumentoEntrevistaPersona");

                entity.Property(e => e.Empresa).HasMaxLength(1500);

                entity.Property(e => e.Nombre).HasMaxLength(1500);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblDocumentoEntrevistaPersona)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumento, d.IdTipoDocumento, d.IdEntrevista })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDocumentoEntrevistaPersona_tblDocumentoEntrevista");
            });

            modelBuilder.Entity<TblDocumentoPersonaClave>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumento, e.IdTipoDocumento, e.IdPersona });

                entity.ToTable("tblDocumentoPersonaClave");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdPersona })
                    .HasName("IX_FK_tblDocumentoPersonaClave_tblPersona");

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.DireccionHabitacion).IsRequired();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.TelefonoCelular)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.TelefonoHabitacion)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.TelefonoOficina)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblDocumentoPersonaClave)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPersonaClave_tblEmpresa");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblDocumentoPersonaClave)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPersona })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDocumentoPersonaClave_tblPersona");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblDocumentoPersonaClave)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumento, d.IdTipoDocumento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblDocumentoPersonaClave_tblDocumento");
            });

            modelBuilder.Entity<TblEmpresa>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.ToTable("tblEmpresa");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("IX_FK_tblEmpresa_tblEstadoEmpresa");

                entity.HasIndex(e => e.IdPais)
                    .HasName("IX_FK_tblEmpresa_tblPais");

                entity.HasIndex(e => new { e.IdPais, e.IdPaisEstado })
                    .HasName("IX_FK_tblEmpresa_tblEstado");

                entity.HasIndex(e => new { e.IdPais, e.IdPaisEstado, e.IdPaisEstadoCiudad })
                    .HasName("IX_FK_tblEmpresa_tblCiudad");

                entity.Property(e => e.DireccionAdministrativa).IsRequired();

                entity.Property(e => e.FechaInicioActividad).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimoEstado).HasColumnType("datetime");

                entity.Property(e => e.LogoUrl)
                    .IsRequired()
                    .HasColumnName("LogoURL")
                    .HasMaxLength(250);

                entity.Property(e => e.NombreComercial)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.NombreFiscal)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.RegistroFiscal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.TblEmpresa)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblEstadoEmpresa");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.TblEmpresa)
                    .HasForeignKey(d => d.IdPais)
                    .HasConstraintName("FK_tblEmpresa_tblPais");

                entity.HasOne(d => d.IdPais1)
                    .WithMany(p => p.TblEmpresa)
                    .HasForeignKey(d => new { d.IdPais, d.IdPaisEstado })
                    .HasConstraintName("FK_tblEmpresa_tblEstado");

                entity.HasOne(d => d.IdPais2)
                    .WithMany(p => p.TblEmpresa)
                    .HasForeignKey(d => new { d.IdPais, d.IdPaisEstado, d.IdPaisEstadoCiudad })
                    .HasConstraintName("FK_tblEmpresa_tblCiudad");
            });

            modelBuilder.Entity<TblEmpresaModulo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdModulo });

                entity.ToTable("tblEmpresaModulo");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblEmpresaModulo)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresaModulo_tblEmpresa");

                entity.HasOne(d => d.Id)
                    .WithOne(p => p.TblEmpresaModulo)
                    .HasForeignKey<TblEmpresaModulo>(d => new { d.IdEmpresa, d.IdModulo })
                    .HasConstraintName("FK_tblEmpresaModulo_tblModulo");
            });

            modelBuilder.Entity<TblEmpresaUsuario>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdUsuario });

                entity.ToTable("tblEmpresaUsuario");

                entity.HasIndex(e => e.IdNivelUsuario)
                    .HasName("IX_FK_tblEmpresaUsuario_tblNivelUsuario");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("IX_FK_tblEmpresaUsuario_tblUsuario");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblEmpresaUsuario)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresaUsuario_tblEmpresa");

                entity.HasOne(d => d.IdNivelUsuarioNavigation)
                    .WithMany(p => p.TblEmpresaUsuario)
                    .HasForeignKey(d => d.IdNivelUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresaUsuario_tblNivelUsuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresaUsuario_tblUsuario");
            });

            modelBuilder.Entity<TblEscala>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdEscala });

                entity.ToTable("tblEscala");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdTipoEscala })
                    .HasName("IX_FK_tblEscala_tblTipoEscala");

                entity.Property(e => e.Descripcion).IsRequired();

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblEscala)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblEscala_FK1");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblEscala)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdTipoEscala })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEscala_tblTipoEscala");
            });

            modelBuilder.Entity<TblEstado>(entity =>
            {
                entity.HasKey(e => new { e.IdPais, e.IdEstado });

                entity.ToTable("tblEstado");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.TblEstado)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPais_tblEstado_FK1");
            });

            modelBuilder.Entity<TblEstadoDocumento>(entity =>
            {
                entity.HasKey(e => e.IdEstadoDocumento);

                entity.ToTable("tblEstadoDocumento");

                entity.Property(e => e.IdEstadoDocumento).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblEstadoEmpresa>(entity =>
            {
                entity.HasKey(e => e.IdEstadoEmpresa);

                entity.ToTable("tblEstadoEmpresa");

                entity.Property(e => e.IdEstadoEmpresa).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblEstadoProceso>(entity =>
            {
                entity.HasKey(e => e.IdEstadoProceso);

                entity.ToTable("tblEstadoProceso");

                entity.Property(e => e.IdEstadoProceso).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblEstadoRiesgo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdEstadoRiesgo });

                entity.ToTable("tblEstadoRiesgo");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TblEstadoUsuario>(entity =>
            {
                entity.HasKey(e => e.IdEstadoUsuario);

                entity.ToTable("tblEstadoUsuario");

                entity.Property(e => e.IdEstadoUsuario).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblFormatosEmail>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdCodigoModulo, e.IdCorreo });

                entity.ToTable("tblFormatosEmail");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(1500);

                entity.Property(e => e.EmailBody).IsRequired();

                entity.Property(e => e.Subject).HasMaxLength(450);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblFormatosEmail)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblFormatosEmail_tblEmpresa");
            });

            modelBuilder.Entity<TblFuenteIncidente>(entity =>
            {
                entity.HasKey(e => e.IdFuenteIncidente);

                entity.ToTable("tblFuenteIncidente");
            });

            modelBuilder.Entity<TblFuenteRiesgo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.CodigoFuente });

                entity.ToTable("tblFuenteRiesgo");

                entity.Property(e => e.CodigoFuente)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblImpactoRiesgo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdImpacto });

                entity.ToTable("tblImpactoRiesgo");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<TblIncidentes>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdIncidente });

                entity.ToTable("tblIncidentes");

                entity.HasIndex(e => e.IdFuenteIncidente)
                    .HasName("IX_FK_tblIncidentes_tblFuenteIncidente");

                entity.HasIndex(e => e.IdNaturalezaIncidente)
                    .HasName("IX_FK_tblIncidentes_tblNaturalezaIncidente");

                entity.HasIndex(e => e.IdTipoIncidente)
                    .HasName("IX_FK_tblIncidentes_tblTipoIncidente");

                entity.Property(e => e.IdIncidente).ValueGeneratedOnAdd();

                entity.Property(e => e.FechaIncidente).HasColumnType("datetime");

                entity.Property(e => e.NombreReportero).HasMaxLength(500);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblIncidentes)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIncidentes_tblEmpresa");

                entity.HasOne(d => d.IdFuenteIncidenteNavigation)
                    .WithMany(p => p.TblIncidentes)
                    .HasForeignKey(d => d.IdFuenteIncidente)
                    .HasConstraintName("FK_tblIncidentes_tblFuenteIncidente");

                entity.HasOne(d => d.IdNaturalezaIncidenteNavigation)
                    .WithMany(p => p.TblIncidentes)
                    .HasForeignKey(d => d.IdNaturalezaIncidente)
                    .HasConstraintName("FK_tblIncidentes_tblNaturalezaIncidente");

                entity.HasOne(d => d.IdTipoIncidenteNavigation)
                    .WithMany(p => p.TblIncidentes)
                    .HasForeignKey(d => d.IdTipoIncidente)
                    .HasConstraintName("FK_tblIncidentes_tblTipoIncidente");
            });

            modelBuilder.Entity<TblIniciativaPrioridad>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPrioridad });

                entity.ToTable("tblIniciativaPrioridad");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<TblIniciativaResponsable>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdResponsable });

                entity.ToTable("tblIniciativaResponsable");

                entity.Property(e => e.IdResponsable).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre).HasMaxLength(150);
            });

            modelBuilder.Entity<TblIniciativas>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdIniciativa });

                entity.ToTable("tblIniciativas");

                entity.HasIndex(e => e.IdEstatusIniciativa)
                    .HasName("IX_FK_tblIniciativas_tblPlanTrabajoEstatus");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdPrioridad })
                    .HasName("IX_FK_tblIniciativas_tblIniciativaPrioridad");

                entity.Property(e => e.IdIniciativa).ValueGeneratedOnAdd();

                entity.Property(e => e.FechaCierreEstimada).HasColumnType("datetime");

                entity.Property(e => e.FechaCierreReal).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioEstimada).HasColumnType("datetime");

                entity.Property(e => e.FechaInicioReal).HasColumnType("datetime");

                entity.Property(e => e.MontoAbonado).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.MontoPendiente).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.Nombre).HasMaxLength(1500);

                entity.Property(e => e.NombreResponsable).HasMaxLength(1500);

                entity.Property(e => e.PorcentajeAvance).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PresupuestoEstimado).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.PresupuestoReal).HasColumnType("decimal(19, 4)");

                entity.Property(e => e.UnidadOrganizativa).HasMaxLength(1500);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblIniciativas)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIniciativas_tblEmpresa");

                entity.HasOne(d => d.IdEstatusIniciativaNavigation)
                    .WithMany(p => p.TblIniciativas)
                    .HasForeignKey(d => d.IdEstatusIniciativa)
                    .HasConstraintName("FK_tblIniciativas_tblPlanTrabajoEstatus");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblIniciativas)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPrioridad })
                    .HasConstraintName("FK_tblIniciativas_tblIniciativaPrioridad");
            });

            modelBuilder.Entity<TblIniciativasAnexo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdIniciativa, e.IdAnexo });

                entity.ToTable("tblIniciativas_Anexo");

                entity.Property(e => e.IdAnexo).ValueGeneratedOnAdd();

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fechaRegistro")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nombre).HasMaxLength(1500);

                entity.Property(e => e.RutaArchivo).HasMaxLength(1500);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblIniciativasAnexo)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblIniciativas_Anexo_tblEmpresa");
            });

            modelBuilder.Entity<TblLocalidad>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdLocalidad });

                entity.ToTable("tblLocalidad");

                entity.HasIndex(e => e.IdPais)
                    .HasName("IX_FK_tblLocalidad_tblPais");

                entity.HasIndex(e => new { e.IdPais, e.IdEstado })
                    .HasName("IX_FK_tblLocalidad_tblEstado");

                entity.HasIndex(e => new { e.IdPais, e.IdEstado, e.IdCiudad })
                    .HasName("IX_FK_tblLocalidad_tblCiudad");

                entity.Property(e => e.IdLocalidad).ValueGeneratedOnAdd();

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblLocalidad)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblLocalidad_FK1");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.TblLocalidad)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblLocalidad_tblPais");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblLocalidad)
                    .HasForeignKey(d => new { d.IdPais, d.IdEstado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblLocalidad_tblEstado");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblLocalidad)
                    .HasForeignKey(d => new { d.IdPais, d.IdEstado, d.IdCiudad })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblLocalidad_tblCiudad");
            });

            modelBuilder.Entity<TblMes>(entity =>
            {
                entity.HasKey(e => e.IdMes);

                entity.ToTable("tblMes");

                entity.Property(e => e.IdMes).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblModulo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdModulo });

                entity.ToTable("tblModulo");

                entity.Property(e => e.Accion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Controller)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion).HasMaxLength(4000);

                entity.Property(e => e.ImageRoot)
                    .HasColumnName("imageRoot")
                    .HasMaxLength(500);

                entity.Property(e => e.Nombre).HasMaxLength(250);

                entity.Property(e => e.Titulo).HasMaxLength(450);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblModulo)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK_tblModulo_tblEmpresa");
            });

            modelBuilder.Entity<TblModuloAnexo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdModulo, e.Negocios, e.IdAnexo });

                entity.ToTable("tblModuloAnexo");

                entity.Property(e => e.IdAnexo).ValueGeneratedOnAdd();

                entity.Property(e => e.LastWriteTime).HasColumnType("datetime");

                entity.Property(e => e.Nombre).HasMaxLength(500);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblModuloAnexo)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblModuloAnexo_tblEmpresa");
            });

            modelBuilder.Entity<TblModuloNivelUsuario>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdNivelUsuario, e.IdModulo });

                entity.ToTable("tblModulo_NivelUsuario");

                entity.HasIndex(e => e.IdNivelUsuario)
                    .HasName("IX_FK_tblModulo_NivelUsuario_tblNivelUsuario");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdModulo })
                    .HasName("IX_FK_tblModulo_NivelUsuario_tblModulo");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblModuloNivelUsuario)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblModulo_NivelUsuario_tblEmpresa");

                entity.HasOne(d => d.IdNivelUsuarioNavigation)
                    .WithMany(p => p.TblModuloNivelUsuario)
                    .HasForeignKey(d => d.IdNivelUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblModulo_NivelUsuario_tblNivelUsuario");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblModuloNivelUsuario)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdModulo })
                    .HasConstraintName("FK_tblModulo_NivelUsuario_tblModulo");
            });

            modelBuilder.Entity<TblModuloUsuario>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdModulo, e.IdUsuario });

                entity.ToTable("tblModulo_Usuario");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("IX_FK_tblModulo_Usuario_tblUsuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.MenuOptions)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblModulo_Usuario_tblUsuario");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblModuloUsuario)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdModulo })
                    .HasConstraintName("FK_tblModulo_Usuario_tblModulo");
            });

            modelBuilder.Entity<TblNaturalezaIncidente>(entity =>
            {
                entity.HasKey(e => e.IdNaturalezaIncidente);

                entity.ToTable("tblNaturalezaIncidente");
            });

            modelBuilder.Entity<TblNivelImpacto>(entity =>
            {
                entity.HasKey(e => e.IdNivelImpacto);

                entity.ToTable("tblNivelImpacto");

                entity.Property(e => e.IdNivelImpacto).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblNivelUsuario>(entity =>
            {
                entity.HasKey(e => e.IdNivelUsuario);

                entity.ToTable("tblNivelUsuario");

                entity.Property(e => e.IdNivelUsuario).ValueGeneratedNever();

                entity.Property(e => e.RolUsuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPais>(entity =>
            {
                entity.HasKey(e => e.IdPais);

                entity.ToTable("tblPais");

                entity.Property(e => e.IdPais).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblPbepruebaEjecucion>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPlanificacion });

                entity.ToTable("tblPBEPruebaEjecucion");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.Lugar)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblPbepruebaEjecucion)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucion_tblEmpresa");

                entity.HasOne(d => d.Id)
                    .WithOne(p => p.TblPbepruebaEjecucion)
                    .HasForeignKey<TblPbepruebaEjecucion>(d => new { d.IdEmpresa, d.IdPlanificacion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucion_tblPBEPruebaPlanificacion");
            });

            modelBuilder.Entity<TblPbepruebaEjecucionEjercicio>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPlanificacion, e.IdEjercicio });

                entity.ToTable("tblPBEPruebaEjecucionEjercicio");

                entity.HasIndex(e => e.IdEstatus)
                    .HasName("IX_FK_tblPBEPruebaEjecucionEjercicio_tblPBEPruebaEjecucionEstatus");

                entity.Property(e => e.IdEjercicio).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).IsRequired();

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblPbepruebaEjecucionEjercicio)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicio_tblEmpresa");

                entity.HasOne(d => d.IdEstatusNavigation)
                    .WithMany(p => p.TblPbepruebaEjecucionEjercicio)
                    .HasForeignKey(d => d.IdEstatus)
                    .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicio_tblPBEPruebaEjecucionEstatus");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPbepruebaEjecucionEjercicio)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPlanificacion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicio_tblPBEPruebaEjecucion");
            });

            modelBuilder.Entity<TblPbepruebaEjecucionEjercicioParticipante>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPlanificacion, e.IdEjercicio, e.IdParticipante });

                entity.ToTable("tblPBEPruebaEjecucionEjercicioParticipante");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdPlanificacion, e.IdParticipante })
                    .HasName("IX_FK_tblPBEPruebaEjecucionEjercicioParticipante_tblPBEPruebaEjecucionParticipante");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPbepruebaEjecucionEjercicioParticipante)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPlanificacion, d.IdEjercicio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicioParticipante_tblPBEPruebaEjecucionEjercicio");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblPbepruebaEjecucionEjercicioParticipante)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPlanificacion, d.IdParticipante })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicioParticipante_tblPBEPruebaEjecucionParticipante");
            });

            modelBuilder.Entity<TblPbepruebaEjecucionEjercicioRecurso>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPlanificacion, e.IdEjercicio, e.IdRecurso });

                entity.ToTable("tblPBEPruebaEjecucionEjercicioRecurso");

                entity.Property(e => e.IdRecurso).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).IsRequired();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPbepruebaEjecucionEjercicioRecurso)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPlanificacion, d.IdEjercicio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicioRecurso_tblPBEPruebaEjecucionEjercicio");
            });

            modelBuilder.Entity<TblPbepruebaEjecucionParticipante>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPlanificacion, e.IdParticipante });

                entity.ToTable("tblPBEPruebaEjecucionParticipante");

                entity.Property(e => e.IdParticipante).ValueGeneratedOnAdd();

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPbepruebaEjecucionParticipante)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPlanificacion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucionParticipante_tblPBEPruebaEjecucion");
            });

            modelBuilder.Entity<TblPbepruebaEjecucionResultado>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPlanificacion, e.IdContenido });

                entity.ToTable("tblPBEPruebaEjecucionResultado");

                entity.Property(e => e.Contenido).IsRequired();

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPbepruebaEjecucionResultado)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPlanificacion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaEjecucionResultado_tblPBEPruebaEjecucion");
            });

            modelBuilder.Entity<TblPbepruebaEstatus>(entity =>
            {
                entity.HasKey(e => e.IdEstatus);

                entity.ToTable("tblPBEPruebaEstatus");

                entity.Property(e => e.IdEstatus).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblPbepruebaPlanificacion>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPlanificacion });

                entity.ToTable("tblPBEPruebaPlanificacion");

                entity.Property(e => e.IdPlanificacion).ValueGeneratedOnAdd();

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.Lugar)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Propósito).IsRequired();

                entity.Property(e => e.Prueba)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblPbepruebaPlanificacion)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaPlanificacion_tblEmpresa");
            });

            modelBuilder.Entity<TblPbepruebaPlanificacionEjercicio>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPlanificacion, e.IdEjercicio });

                entity.ToTable("tblPBEPruebaPlanificacionEjercicio");

                entity.Property(e => e.IdEjercicio).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).IsRequired();

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPbepruebaPlanificacionEjercicio)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPlanificacion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaPlanificacionEjercicio_tblPBEPruebaPlanificacion");
            });

            modelBuilder.Entity<TblPbepruebaPlanificacionEjercicioParticipante>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPlanificacion, e.IdEjercicio, e.IdParticipante });

                entity.ToTable("tblPBEPruebaPlanificacionEjercicioParticipante");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdPlanificacion, e.IdParticipante })
                    .HasName("IX_FK_tblPBEPruebaPlanificacionEjercicioParticipante_tblPBEPruebaPlanificacionParticipante");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPbepruebaPlanificacionEjercicioParticipante)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPlanificacion, d.IdEjercicio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaPlanificacionEjercicioParticipante_tblPBEPruebaPlanificacionEjercicio");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblPbepruebaPlanificacionEjercicioParticipante)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPlanificacion, d.IdParticipante })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaPlanificacionEjercicioParticipante_tblPBEPruebaPlanificacionParticipante");
            });

            modelBuilder.Entity<TblPbepruebaPlanificacionEjercicioRecurso>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPlanificacion, e.IdEjercicio, e.IdRecurso });

                entity.ToTable("tblPBEPruebaPlanificacionEjercicioRecurso");

                entity.Property(e => e.IdRecurso).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPbepruebaPlanificacionEjercicioRecurso)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPlanificacion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaPlanificacionRecurso_tblPBEPruebaPlanificacion");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblPbepruebaPlanificacionEjercicioRecurso)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPlanificacion, d.IdEjercicio })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaPlanificacionEjercicioRecurso_tblPBEPruebaPlanificacionEjercicio");
            });

            modelBuilder.Entity<TblPbepruebaPlanificacionParticipante>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPlanificacion, e.IdParticipante });

                entity.ToTable("tblPBEPruebaPlanificacionParticipante");

                entity.Property(e => e.IdParticipante).ValueGeneratedOnAdd();

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPbepruebaPlanificacionParticipante)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPlanificacion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPBEPruebaPlanificacionParticipante_tblPBEPruebaPlanificacion");
            });

            modelBuilder.Entity<TblPersona>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPersona });

                entity.ToTable("tblPersona");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("IX_FK_tblPersona_tblUsuario");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdCargo })
                    .HasName("IX_FK_tblCargo_tblPersona_FK1");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdUnidadOrganizativa })
                    .HasName("IX_FK_tblPersona_tblUnidadOrganizativa");

                entity.Property(e => e.IdPersona).ValueGeneratedOnAdd();

                entity.Property(e => e.Identificacion).HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblPersona)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblPersona_FK1");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_tblPersona_tblUsuario");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPersona)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdCargo })
                    .HasConstraintName("FK_tblCargo_tblPersona_FK1");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblPersona)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdUnidadOrganizativa })
                    .HasConstraintName("FK_tblPersona_tblUnidadOrganizativa");
            });

            modelBuilder.Entity<TblPersonaCorreo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPersona, e.IdPersonaCorreo });

                entity.ToTable("tblPersonaCorreo");

                entity.HasIndex(e => e.IdTipoCorreo)
                    .HasName("IX_FK_tblPersonaCorreo_tblTipoCorreo");

                entity.Property(e => e.IdPersonaCorreo).ValueGeneratedOnAdd();

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.IdTipoCorreoNavigation)
                    .WithMany(p => p.TblPersonaCorreo)
                    .HasForeignKey(d => d.IdTipoCorreo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPersonaCorreo_tblTipoCorreo");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPersonaCorreo)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPersona })
                    .HasConstraintName("FK_tblPersonaCorreo_tblPersona");
            });

            modelBuilder.Entity<TblPersonaDireccion>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPersona, e.IdPersonaDireccion });

                entity.ToTable("tblPersonaDireccion");

                entity.HasIndex(e => e.IdPais)
                    .HasName("IX_FK_tblPersonaDireccion_tblPais");

                entity.HasIndex(e => e.IdTipoDireccion)
                    .HasName("IX_FK_tblPersonaDireccion_tblTipoDireccion");

                entity.HasIndex(e => new { e.IdPais, e.IdEstado })
                    .HasName("IX_FK_tblPersonaDireccion_tblEstado");

                entity.HasIndex(e => new { e.IdPais, e.IdEstado, e.IdCiudad })
                    .HasName("IX_FK_tblPersonaDireccion_tblCiudad");

                entity.Property(e => e.IdPersonaDireccion).ValueGeneratedOnAdd();

                entity.Property(e => e.Ubicacion).HasMaxLength(1500);

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.TblPersonaDireccion)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPersonaDireccion_tblPais");

                entity.HasOne(d => d.IdTipoDireccionNavigation)
                    .WithMany(p => p.TblPersonaDireccion)
                    .HasForeignKey(d => d.IdTipoDireccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPersonaDireccion_tblTipoDireccion");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPersonaDireccion)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPersona })
                    .HasConstraintName("FK_tblPersona_tblPersonaDireccion_FK1");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblPersonaDireccion)
                    .HasForeignKey(d => new { d.IdPais, d.IdEstado })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPersonaDireccion_tblEstado");

                entity.HasOne(d => d.Id1)
                    .WithMany(p => p.TblPersonaDireccion)
                    .HasForeignKey(d => new { d.IdPais, d.IdEstado, d.IdCiudad })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPersonaDireccion_tblCiudad");
            });

            modelBuilder.Entity<TblPersonaTelefono>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPersona, e.IdPersonaTelefono });

                entity.ToTable("tblPersonaTelefono");

                entity.HasIndex(e => e.IdTipoTelefono)
                    .HasName("IX_FK_tblPersonaTelefono_tblTipoTelefono");

                entity.Property(e => e.IdPersonaTelefono).ValueGeneratedOnAdd();

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoTelefonoNavigation)
                    .WithMany(p => p.TblPersonaTelefono)
                    .HasForeignKey(d => d.IdTipoTelefono)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPersonaTelefono_tblTipoTelefono");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPersonaTelefono)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdPersona })
                    .HasConstraintName("FK_tblPersona_tblPersonaTelefono_FK1");
            });

            modelBuilder.Entity<TblPlanTrabajo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdAccion, e.IdActividad });

                entity.ToTable("tblPlanTrabajo");

                entity.HasIndex(e => e.Ejecutada)
                    .HasName("IX_FK_tblPlanTrabajo_tblPlanTrabajoEstatus");

                entity.Property(e => e.IdActividad).ValueGeneratedOnAdd();

                entity.Property(e => e.FechaPropuestaEjecucion).HasColumnType("datetime");

                entity.Property(e => e.Recomendacion)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.EjecutadaNavigation)
                    .WithMany(p => p.TblPlanTrabajo)
                    .HasForeignKey(d => d.Ejecutada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlanTrabajo_tblPlanTrabajoEstatus");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblPlanTrabajo)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlanTrabajo_tblEmpresa");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPlanTrabajo)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdAccion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlanTrabajo_tblPlanTrabajoAccion");
            });

            modelBuilder.Entity<TblPlanTrabajoAccion>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdPlanAccion });

                entity.ToTable("tblPlanTrabajoAccion");

                entity.Property(e => e.IdPlanAccion).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblPlanTrabajoAccion)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlanTrabajoAccion_tblEmpresa");
            });

            modelBuilder.Entity<TblPlanTrabajoAuditoria>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdAccion, e.IdActividad, e.IdCambioEstado });

                entity.ToTable("tblPlanTrabajoAuditoria");

                entity.HasIndex(e => e.Estado)
                    .HasName("IX_FK_tblPlanTrabajoAuditoria_tblPlanTrabajoEstatus");

                entity.HasIndex(e => e.IdUsuarioCambioEstado)
                    .HasName("IX_FK_tblPlanTrabajoAuditoria_tblUsuario");

                entity.Property(e => e.IdCambioEstado).ValueGeneratedOnAdd();

                entity.Property(e => e.FechaCambioEstado).HasColumnType("datetime");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.TblPlanTrabajoAuditoria)
                    .HasForeignKey(d => d.Estado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlanTrabajoAuditoria_tblPlanTrabajoEstatus");

                entity.HasOne(d => d.IdUsuarioCambioEstadoNavigation)
                    .WithMany(p => p.WorkPlannAudits)
                    .HasForeignKey(d => d.IdUsuarioCambioEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlanTrabajoAuditoria_tblUsuario");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPlanTrabajoAuditoria)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdAccion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPlanTrabajoAuditoria_tblPlanTrabajoAccion");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblPlanTrabajoAuditoria)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdAccion, d.IdActividad })
                    .HasConstraintName("FK_tblPlanTrabajoAuditoria_tblPlanTrabajo");
            });

            modelBuilder.Entity<TblPlanTrabajoEstatus>(entity =>
            {
                entity.HasKey(e => e.IdEstatusActividad);

                entity.ToTable("tblPlanTrabajoEstatus");

                entity.Property(e => e.IdEstatusActividad).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblPmtmensajeActualizacion>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdMensaje, e.IdModulo });

                entity.ToTable("tblPMTMensajeActualizacion");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdModulo })
                    .HasName("IX_FK_tblPMTMensajeActualizacion_tblModulo");

                entity.Property(e => e.IdMensaje).ValueGeneratedOnAdd();

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaUltimoEnvio).HasColumnType("datetime");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblPmtmensajeActualizacion)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTMensajeActualizacion_tblEmpresa");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPmtmensajeActualizacion)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdModulo })
                    .HasConstraintName("FK_tblPMTMensajeActualizacion_tblModulo");
            });

            modelBuilder.Entity<TblPmtprogramacion>(entity =>
            {
                entity.HasKey(e => e.IdPmtprogramacion);

                entity.ToTable("tblPMTProgramacion");

                entity.HasIndex(e => e.IdEmpresa)
                    .HasName("IX_FK_tblPMTProgramacion_tblEmpresa");

                entity.HasIndex(e => e.IdTipoActualizacion)
                    .HasName("IX_FK_tblPMTProgramacion_tblPMTProgramacionTipoActualizacion");

                entity.HasIndex(e => e.IdTipoFrecuencia)
                    .HasName("IX_FK_tblPMTProgramacion_tblTipoFrecuencia");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdModulo })
                    .HasName("IX_FK_tblPMTProgramacion_tblModulo");

                entity.Property(e => e.IdPmtprogramacion).HasColumnName("IdPMTProgramacion");

                entity.Property(e => e.FechaFinal).HasColumnType("datetime");

                entity.Property(e => e.FechaInicio).HasColumnType("datetime");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblPmtprogramacion)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacion_tblEmpresa");

                entity.HasOne(d => d.IdTipoActualizacionNavigation)
                    .WithMany(p => p.TblPmtprogramacion)
                    .HasForeignKey(d => d.IdTipoActualizacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacion_tblPMTProgramacionTipoActualizacion");

                entity.HasOne(d => d.IdTipoFrecuenciaNavigation)
                    .WithMany(p => p.TblPmtprogramacion)
                    .HasForeignKey(d => d.IdTipoFrecuencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacion_tblTipoFrecuencia");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPmtprogramacion)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdModulo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacion_tblModulo");
            });

            modelBuilder.Entity<TblPmtprogramacionDocumentos>(entity =>
            {
                entity.HasKey(e => new { e.IdPmtprogramacion, e.IdEmpresa, e.IdModulo, e.IdDocumento });

                entity.ToTable("tblPMTProgramacionDocumentos");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdModulo })
                    .HasName("IX_FK_tblPMTProgramacionDocumentos_tblModulo");

                entity.HasIndex(e => new { e.IdEmpresa, e.IdDocumento, e.IdTipoDocumento })
                    .HasName("IX_FK_tblPMTProgramacionDocumentos_tblDocumento");

                entity.Property(e => e.IdPmtprogramacion).HasColumnName("IdPMTProgramacion");

                entity.HasOne(d => d.IdPmtprogramacionNavigation)
                    .WithMany(p => p.TblPmtprogramacionDocumentos)
                    .HasForeignKey(d => d.IdPmtprogramacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacionDocumentos_tblPMTProgramacion");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPmtprogramacionDocumentos)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdModulo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacionDocumentos_tblModulo");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblPmtprogramacionDocumentos)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumento, d.IdTipoDocumento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacionDocumentos_tblDocumento");
            });

            modelBuilder.Entity<TblPmtprogramacionTipoActualizacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoActualizacion);

                entity.ToTable("tblPMTProgramacionTipoActualizacion");

                entity.Property(e => e.IdTipoActualizacion).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblPmtprogramacionTipoNotificacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoNotificacion);

                entity.ToTable("tblPMTProgramacionTipoNotificacion");

                entity.Property(e => e.IdTipoNotificacion).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblPmtprogramacionUsuario>(entity =>
            {
                entity.HasKey(e => new { e.IdPmtprogramacion, e.IdUsuario });

                entity.ToTable("tblPMTProgramacionUsuario");

                entity.HasIndex(e => e.IdTipoNotificacion)
                    .HasName("IX_FK_tblPMTProgramacionUsuario_tblPMTProgramacionTipoNotificacion");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("IX_FK_tblPMTProgramacionUsuario_tblUsuario");

                entity.Property(e => e.IdPmtprogramacion).HasColumnName("IdPMTProgramacion");

                entity.Property(e => e.FechaUltimaNotificacion).HasColumnType("datetime");

                entity.HasOne(d => d.IdPmtprogramacionNavigation)
                    .WithMany(p => p.TblPmtprogramacionUsuario)
                    .HasForeignKey(d => d.IdPmtprogramacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacionUsuario_tblPMTProgramacion");

                entity.HasOne(d => d.IdTipoNotificacionNavigation)
                    .WithMany(p => p.TblPmtprogramacionUsuario)
                    .HasForeignKey(d => d.IdTipoNotificacion)
                    .HasConstraintName("FK_tblPMTProgramacionUsuario_tblPMTProgramacionTipoNotificacion");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.MaintenancePlanSchedules)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTProgramacionUsuario_tblUsuario");
            });

            modelBuilder.Entity<TblPmtresponsableUpdate>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdModulo, e.IdMensaje });

                entity.ToTable("tblPMTResponsableUpdate");

                entity.Property(e => e.IdMensaje).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblPmtresponsableUpdate)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTResponsableUpdate_tblEmpresa");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPmtresponsableUpdate)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdModulo })
                    .HasConstraintName("FK_tblPMTResponsableUpdate_tblModulo");
            });

            modelBuilder.Entity<TblPmtresponsableUpdateCorreo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdModulo, e.IdMensaje, e.IdUsuario });

                entity.ToTable("tblPMTResponsableUpdate_Correo");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("IX_FK_tblPMTResponsableUpdate_Correo_tblUsuario");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.MaintenancePlanUpdateEmails)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTResponsableUpdate_Correo_tblUsuario");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPmtresponsableUpdateCorreo)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdModulo, d.IdMensaje })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPMTResponsableUpdate_Correo_tblPMTResponsableUpdate");
            });

            modelBuilder.Entity<TblPpefrecuencia>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdDocumento, e.IdTipoDocumento, e.IdPpefrecuencia });

                entity.ToTable("tblPPEFrecuencia");

                entity.HasIndex(e => e.IdTipoFrecuencia)
                    .HasName("IX_FK_tblPPEFrecuencia_tblTipoFrecuencia");

                entity.Property(e => e.IdPpefrecuencia)
                    .HasColumnName("IdPPEFrecuencia")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Participantes)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.Proposito)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.TipoPrueba)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.IdTipoFrecuenciaNavigation)
                    .WithMany(p => p.TblPpefrecuencia)
                    .HasForeignKey(d => d.IdTipoFrecuencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPPEFrecuencia_tblTipoFrecuencia");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblPpefrecuencia)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdDocumento, d.IdTipoDocumento })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblPPEFrecuencia_tblDocumento");
            });

            modelBuilder.Entity<TblProbabilidadRiesgo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdProbabilidad });

                entity.ToTable("tblProbabilidadRiesgo");

                entity.Property(e => e.EtiquetaGrafico).HasMaxLength(250);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblProbabilidadRiesgo)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBIAProbabilidadRiesgo_tblEmpresa");
            });

            modelBuilder.Entity<TblProducto>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdProducto });

                entity.ToTable("tblProducto");

                entity.Property(e => e.IdProducto).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblProducto)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblProducto_tblEmpresa");
            });

            modelBuilder.Entity<TblProveedor>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdProveedor });

                entity.ToTable("tblProveedor");

                entity.Property(e => e.IdProveedor).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblProveedor)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblProveedor_FK1");
            });

            modelBuilder.Entity<TblSeveridadRiesgo>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdSeveridad });

                entity.ToTable("tblSeveridadRiesgo");

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<TblTipoCorreo>(entity =>
            {
                entity.HasKey(e => e.IdTipoCorreo);

                entity.ToTable("tblTipoCorreo");

                entity.Property(e => e.IdTipoCorreo).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblTipoDireccion>(entity =>
            {
                entity.HasKey(e => e.IdTipoDireccion);

                entity.ToTable("tblTipoDireccion");

                entity.Property(e => e.IdTipoDireccion).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblTipoEscala>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdTipoEscala });

                entity.ToTable("tblTipoEscala");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<TblTipoFrecuencia>(entity =>
            {
                entity.HasKey(e => e.IdTipoFrecuencia);

                entity.ToTable("tblTipoFrecuencia");

                entity.Property(e => e.IdTipoFrecuencia).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblTipoImpacto>(entity =>
            {
                entity.HasKey(e => e.IdTipoImpacto);

                entity.ToTable("tblTipoImpacto");

                entity.Property(e => e.IdTipoImpacto).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblTipoIncidente>(entity =>
            {
                entity.HasKey(e => e.IdTipoIncidente);

                entity.ToTable("tblTipoIncidente");
            });

            modelBuilder.Entity<TblTipoInterdependencia>(entity =>
            {
                entity.HasKey(e => e.IdTipoInterdependencia);

                entity.ToTable("tblTipoInterdependencia");

                entity.Property(e => e.IdTipoInterdependencia).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblTipoRespaldo>(entity =>
            {
                entity.HasKey(e => e.IdTipoRespaldo);

                entity.ToTable("tblTipoRespaldo");

                entity.Property(e => e.IdTipoRespaldo).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblTipoResultadoPrueba>(entity =>
            {
                entity.HasKey(e => e.IdTipoResultadoPrueba);

                entity.ToTable("tblTipoResultadoPrueba");

                entity.Property(e => e.IdTipoResultadoPrueba).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblTipoTablaContenido>(entity =>
            {
                entity.HasKey(e => e.IdTipoTablaContenido);

                entity.ToTable("tblTipoTablaContenido");

                entity.Property(e => e.IdTipoTablaContenido).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblTipoTelefono>(entity =>
            {
                entity.HasKey(e => e.IdTipoTelefono);

                entity.ToTable("tblTipoTelefono");

                entity.Property(e => e.IdTipoTelefono).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblTipoUbicacionInformacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoUbicacionInformacion);

                entity.ToTable("tblTipoUbicacionInformacion");

                entity.Property(e => e.IdTipoUbicacionInformacion).ValueGeneratedNever();
            });

            modelBuilder.Entity<TblUnidadOrganizativa>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdUnidadOrganizativa });

                entity.ToTable("tblUnidadOrganizativa");

                entity.Property(e => e.IdUnidadOrganizativa).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblUnidadOrganizativa)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblUnidadOrganizativa_FK1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("tblUsuario");

                entity.HasIndex(e => e.UserStateId)
                    .HasName("IX_FK_tblUsuario_tblEstadoUsuario");

                entity.Property(e => e.UserPassw)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.UserStateDateChange).HasColumnType("datetime");

                entity.Property(e => e.LastConnectionDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.UserStateNavigation)
                    .WithMany(p => p.TblUsuario)
                    .HasForeignKey(d => d.UserStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUsuario_tblEstadoUsuario");
            });

            modelBuilder.Entity<TblUsuarioUnidadOrganizativa>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdUnidadOrganizativa, e.IdUsuario });

                entity.ToTable("tblUsuarioUnidadOrganizativa");

                entity.HasIndex(e => e.IdNivelUsuario)
                    .HasName("IX_FK_tblUsuarioUnidadOrganizativa_tblNivelUsuario");

                entity.HasIndex(e => e.IdUsuario)
                    .HasName("IX_FK_tblUsuarioUnidadOrganizativa_tblUsuario");

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblUsuarioUnidadOrganizativa)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUsuarioUnidadOrganizativa_tblEmpresa");

                entity.HasOne(d => d.IdNivelUsuarioNavigation)
                    .WithMany(p => p.TblUsuarioUnidadOrganizativa)
                    .HasForeignKey(d => d.IdNivelUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUsuarioUnidadOrganizativa_tblNivelUsuario");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.OrganizationUnits)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUsuarioUnidadOrganizativa_tblUsuario");

                entity.HasOne(d => d.Id)
                    .WithMany(p => p.TblUsuarioUnidadOrganizativa)
                    .HasForeignKey(d => new { d.IdEmpresa, d.IdUnidadOrganizativa })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblUsuarioUnidadOrganizativa_tblUnidadOrganizativa");
            });

            modelBuilder.Entity<TblVicepresidencia>(entity =>
            {
                entity.HasKey(e => new { e.IdEmpresa, e.IdVicepresidencia });

                entity.ToTable("tblVicepresidencia");

                entity.HasIndex(e => e.IdPais)
                    .HasName("IX_FK_tblVicepresidencia_tblPais");

                entity.Property(e => e.IdVicepresidencia).ValueGeneratedOnAdd();

                entity.Property(e => e.CalleAvenida)
                    .IsRequired()
                    .HasMaxLength(450);

                entity.Property(e => e.EdificioCasa)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.PisoNivel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TorreAla)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Urbanizacion)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.TblVicepresidencia)
                    .HasForeignKey(d => d.IdEmpresa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblEmpresa_tblVicepresidencia_FK1");

                entity.HasOne(d => d.IdPaisNavigation)
                    .WithMany(p => p.TblVicepresidencia)
                    .HasForeignKey(d => d.IdPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblVicepresidencia_tblPais");
            });
        }
    }
}
