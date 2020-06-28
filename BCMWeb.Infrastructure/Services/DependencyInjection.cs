﻿using BCMWeb.Application.Interfaces;
using BCMWeb.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BCMWeb.Infrastructure.Services
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfraestructure(this IServiceCollection services)
        {
            //services.AddTransient<IAuditoriaRepository, AuditoriaRepository>();
            //services.AddTransient<IAuditoriaProcesoCriticoRepository, AuditoriaProcesoCriticoRepository>();
            //services.AddTransient<IBCPDocumentoRepository, BCPDocumentoRepository>();
            //services.AddTransient<IBCPReanudacionPersonaClaveRepository, BCPReanudacionPersonaClaveRepository>();
            //services.AddTransient<IBCPReanudacionTareaActividadRepository, BCPReanudacionTareaActividadRepository>();
            //services.AddTransient<IBCPReanudacionTareaRepository, BCPReanudacionTareaRepository>();
            //services.AddTransient<IBCPRecuperacionPersonaClaveRepository, BCPRecuperacionPersonaClaveRepository>();
            //services.AddTransient<IBCPRecuperacionRecursoRepository, BCPRecuperacionRecursoRepository>();
            //services.AddTransient<IBCPRespuestaAccionRepository, BCPRespuestaAccionRepository>();
            //services.AddTransient<IBCPRespuestaRecursoRepository, BCPRespuestaRecursoRepository>();
            //services.AddTransient<IBCPRestauracionEquipoRepository, BCPRestauracionEquipoRepository>();
            //services.AddTransient<IBCPRestauracionInfraestructuraRepository, BCPRestauracionInfraestructuraRepository>();
            //services.AddTransient<IBCPRestauracionMobiliarioRepository, BCPRestauracionMobiliarioRepository>();
            //services.AddTransient<IBCPRestauracionOtroRepository, BCPRestauracionOtroRepository>();
            //services.AddTransient<IBIAAmenazaEventoRepository, BIAAmenazaEventoRepository>();
            //services.AddTransient<IBIAAmenazaRepository, BIAAmenazaRepository>();
            //services.AddTransient<IBIAAplicacionRepository, BIAAplicacionRepository>();
            //services.AddTransient<IBIACadenaServicioRepository, BIACadenaServicioRepository>();
            //services.AddTransient<IBIAClienteProcesoRepository, BIAClienteProcesoRepository>();
            //services.AddTransient<IBIAComentarioRepository, BIAComentarioRepository>();
            //services.AddTransient<IBIADocumentacionRepository, BIADocumentacionRepository>();
            //services.AddTransient<IBIADocumentoRepository, BIADocumentoRepository>();
            //services.AddTransient<IBIAEntradaRepository, BIAEntradaRepository>();
            //services.AddTransient<IBIAEventoControlRepository, BIAEventoControlRepository>();
            //services.AddTransient<IBIAEventoRiesgoRepository, BIAEventoRiesgoRepository>();
            //services.AddTransient<IBIAGranImpactoRepository, BIAGranImpactoRepository>();
            //services.AddTransient<IBIAImpactoFinancieroRepository, BIAImpactoFinancieroRepository>();
            //services.AddTransient<IBIAImpactoOperacionalRepository, BIAImpactoOperacionalRepository>();
            //services.AddTransient<IBIAInterdependenciaRepository, BIAInterdependenciaRepository>();
            //services.AddTransient<IBIAMTDRepository, BIAMTDRepository>();
            //services.AddTransient<IBIAPersonaClaveRepository, BIAPersonaClaveRepository>();
            //services.AddTransient<IBIAPersonaRespaldoProcesoRepository, BIAPersonaRespaldoProcesoRepository>();
            //services.AddTransient<IBIAProcesoAlternoRepository, BIAProcesoAlternoRepository>();
            //services.AddTransient<IBIAProcesoRepository, BIAProcesoRepository>();
            //services.AddTransient<IBIAProveedorRepository, BIAProveedorRepository>();
            //services.AddTransient<IBIARespaldoPrimarioRepository, BIARespaldoPrimarioRepository>();
            //services.AddTransient<IBIARespaldoSecundarioRepository, BIARespaldoSecundarioRepository>();
            //services.AddTransient<IBIARPORepository, BIARPORepository>();
            //services.AddTransient<IBIARTORepository, BIARTORepository>();
            //services.AddTransient<IBIAUnidadTrabajoPersonasRepository, BIAUnidadTrabajoPersonasRepository>();
            //services.AddTransient<IBIAUnidadTrabajoProcesoRepository, BIAUnidadTrabajoProcesoRepository>();
            //services.AddTransient<IBIAUnidadTrabajoRepository, BIAUnidadTrabajoRepository>();
            //services.AddTransient<IBIAWRTRepository, BIAWRTRepository>();
            //services.AddTransient<ICargoRepository, CargoRepository>();
            //services.AddTransient<ICiudadRepository, CiudadRepository>();
            //services.AddTransient<IControlRiesgoRepository, ControlRiesgoRepository>();
            //services.AddTransient<ICriticidadRepository, CriticidadRepository>();
            //services.AddTransient<ICultura_CiudadRepository, Cultura_CiudadRepository>();
            //services.AddTransient<ICultura_EstadoDocumentoRepository, Cultura_EstadoDocumentoRepository>();
            //services.AddTransient<ICultura_EstadoEmpresaRepository, Cultura_EstadoEmpresaRepository>();
            //services.AddTransient<ICultura_EstadoProcesoRepository, Cultura_EstadoProcesoRepository>();
            //services.AddTransient<ICultura_EstadoRepository, Cultura_EstadoRepository>();
            //services.AddTransient<ICultura_EstadoUsuarioRepository, Cultura_EstadoUsuarioRepository>();
            //services.AddTransient<ICultura_MesRepository, Cultura_MesRepository>();
            //services.AddTransient<ICultura_NivelImpactoRepository, Cultura_NivelImpactoRepository>();
            //services.AddTransient<ICultura_NivelUsuarioRepository, Cultura_NivelUsuarioRepository>();
            //services.AddTransient<ICultura_PaisRepository, Cultura_PaisRepository>();
            //services.AddTransient<ICultura_PBEPruebaEstatusRepository, Cultura_PBEPruebaEstatusRepository>();
            //services.AddTransient<ICultura_PlanTrabajoEstatusRepository, Cultura_PlanTrabajoEstatusRepository>();
            //services.AddTransient<ICultura_PMTProgramacionTipoActualizacionRepository, Cultura_PMTProgramacionTipoActualizacionRepository>();
            //services.AddTransient<ICultura_PMTProgramacionTipoNotificacionRepository, Cultura_PMTProgramacionTipoNotificacionRepository>();
            //services.AddTransient<ICultura_TipoCorreoRepository, Cultura_TipoCorreoRepository>();
            //services.AddTransient<ICultura_TipoDireccionRepository, Cultura_TipoDireccionRepository>();
            //services.AddTransient<ICultura_TipoFrecuenciaRepository, Cultura_TipoFrecuenciaRepository>();
            //services.AddTransient<ICultura_TipoImpactoRepository, Cultura_TipoImpactoRepository>();
            //services.AddTransient<ICultura_TipoInterdependenciaRepository, Cultura_TipoInterdependenciaRepository>();
            //services.AddTransient<ICultura_TipoRespaldoRepository, Cultura_TipoRespaldoRepository>();
            //services.AddTransient<ICultura_TipoResultadoPruebaRepository, Cultura_TipoResultadoPruebaRepository>();
            //services.AddTransient<ICultura_TipoTablaContenidoRepository, Cultura_TipoTablaContenidoRepository>();
            //services.AddTransient<ICultura_TipoTelefonoRepository, Cultura_TipoTelefonoRepository>();
            //services.AddTransient<ICultura_TipoUbicacionInformacionRepository, Cultura_TipoUbicacionInformacionRepository>();
            //services.AddTransient<ICulture_FuenteIncidenteRepository, Culture_FuenteIncidenteRepository>();
            //services.AddTransient<ICulture_NaturalezaIncidenteRepository, Culture_NaturalezaIncidenteRepository>();
            //services.AddTransient<ICulture_TipoIncidenteRepository, Culture_TipoIncidenteRepository>();
            //services.AddTransient<IDispositivoConexionRepository, DispositivoConexionRepository>();
            //services.AddTransient<IDispositivoEnvioRepository, DispositivoEnvioRepository>();
            //services.AddTransient<IDeviceRepository, DispositivoRepository>();
            //services.AddTransient<IDocumentoAnexoRepository, DocumentoAnexoRepository>();
            //services.AddTransient<IDocumentoAprobacionRepository, DocumentoAprobacionRepository>();
            //services.AddTransient<IDocumentoCertificacionRepository, DocumentoCertificacionRepository>();
            //services.AddTransient<IDocumentoContenidoRepository, DocumentoContenidoRepository>();
            //services.AddTransient<IDocumentoEntrevistaPersonaRepository, DocumentoEntrevistaPersonaRepository>();
            //services.AddTransient<IDocumentoEntrevistaRepository, DocumentoEntrevistaRepository>();
            //services.AddTransient<IDocumentoPersonaClaveRepository, DocumentoPersonaClaveRepository>();
            //services.AddTransient<IDocumentoRepository, DocumentoRepository>();
            //services.AddTransient<IEmpresaModuloRepository, EmpresaModuloRepository>();
            //services.AddTransient<IEmpresaRepository, EmpresaRepository>();
            //services.AddTransient<IEmpresaUsuarioRepository, EmpresaUsuarioRepository>();
            //services.AddTransient<IEscalaRepository, EscalaRepository>();
            //services.AddTransient<IEstadoDocumentoRepository, EstadoDocumentoRepository>();
            //services.AddTransient<IEstadoEmpresaRepository, EstadoEmpresaRepository>();
            //services.AddTransient<IEstadoProcesoRepository, EstadoProcesoRepository>();
            //services.AddTransient<IEstadoRepository, EstadoRepository>();
            //services.AddTransient<IEstadoRiesgoRepository, EstadoRiesgoRepository>();
            //services.AddTransient<IEstadoUsuarioRepository, EstadoUsuarioRepository>();
            //services.AddTransient<IFormatosEmailRepository, FormatosEmailRepository>();
            //services.AddTransient<IFuenteIncidenteRepository, FuenteIncidenteRepository>();
            //services.AddTransient<IFuenteRiesgoRepository, FuenteRiesgoRepository>();
            //services.AddTransient<IImpactoRiesgoRepository, ImpactoRiesgoRepository>();
            //services.AddTransient<IIncidentesRepository, IncidentesRepository>();
            //services.AddTransient<IIniciativaPrioridadRepository, IniciativaPrioridadRepository>();
            //services.AddTransient<IIniciativaResponsableRepository, IniciativaResponsableRepository>();
            //services.AddTransient<IIniciativasRepository, IniciativasRepository>();
            //services.AddTransient<IIniciativas_AnexoRepository, Iniciativas_AnexoRepository>();
            //services.AddTransient<ILocalidadRepository, LocalidadRepository>();
            //services.AddTransient<IMesRepository, MesRepository>();
            //services.AddTransient<IModuloAnexoRepository, ModuloAnexoRepository>();
            //services.AddTransient<IModuloRepository, ModuloRepository>();
            //services.AddTransient<IModulo_NivelUsuarioRepository, Modulo_NivelUsuarioRepository>();
            //services.AddTransient<IModulo_UsuarioRepository, Modulo_UsuarioRepository>();
            //services.AddTransient<INaturalezaIncidenteRepository, NaturalezaIncidenteRepository>();
            //services.AddTransient<INivelImpactoRepository, NivelImpactoRepository>();
            //services.AddTransient<INivelUsuarioRepository, NivelUsuarioRepository>();
            //services.AddTransient<IPaisRepository, PaisRepository>();
            //services.AddTransient<IPBEPruebaEjecucionEjercicioParticipanteRepository, PBEPruebaEjecucionEjercicioParticipanteRepository>();
            //services.AddTransient<IPBEPruebaEjecucionEjercicioRecursoRepository, PBEPruebaEjecucionEjercicioRecursoRepository>();
            //services.AddTransient<IPBEPruebaEjecucionEjercicioRepository, PBEPruebaEjecucionEjercicioRepository>();
            //services.AddTransient<IPBEPruebaEjecucionParticipanteRepository, PBEPruebaEjecucionParticipanteRepository>();
            //services.AddTransient<IPBEPruebaEjecucionRepository, PBEPruebaEjecucionRepository>();
            //services.AddTransient<IPBEPruebaEjecucionResultadoRepository, PBEPruebaEjecucionResultadoRepository>();
            //services.AddTransient<IPBEPruebaEstatusRepository, PBEPruebaEstatusRepository>();
            //services.AddTransient<IPBEPruebaPlanificacionEjercicioParticipanteRepository, PBEPruebaPlanificacionEjercicioParticipanteRepository>();
            //services.AddTransient<IPBEPruebaPlanificacionEjercicioRecursoRepository, PBEPruebaPlanificacionEjercicioRecursoRepository>();
            //services.AddTransient<IPBEPruebaPlanificacionEjercicioRepository, PBEPruebaPlanificacionEjercicioRepository>();
            //services.AddTransient<IPBEPruebaPlanificacionParticipanteRepository, PBEPruebaPlanificacionParticipanteRepository>();
            //services.AddTransient<IPBEPruebaPlanificacionRepository, PBEPruebaPlanificacionRepository>();
            //services.AddTransient<IPersonaCorreoRepository, PersonaCorreoRepository>();
            //services.AddTransient<IPersonaDireccionRepository, PersonaDireccionRepository>();
            //services.AddTransient<IPersonaRepository, PersonaRepository>();
            //services.AddTransient<IPersonaTelefonoRepository, PersonaTelefonoRepository>();
            //services.AddTransient<IPlanTrabajoAccionRepository, PlanTrabajoAccionRepository>();
            //services.AddTransient<IPlanTrabajoAuditoriaRepository, PlanTrabajoAuditoriaRepository>();
            //services.AddTransient<IPlanTrabajoEstatusRepository, PlanTrabajoEstatusRepository>();
            //services.AddTransient<IPlanTrabajoRepository, PlanTrabajoRepository>();
            //services.AddTransient<IPMTMensajeActualizacionRepository, PMTMensajeActualizacionRepository>();
            //services.AddTransient<IPMTProgramacionDocumentosRepository, PMTProgramacionDocumentosRepository>();
            //services.AddTransient<IPMTProgramacionRepository, PMTProgramacionRepository>();
            //services.AddTransient<IPMTProgramacionTipoActualizacionRepository, PMTProgramacionTipoActualizacionRepository>();
            //services.AddTransient<IPMTProgramacionTipoNotificacionRepository, PMTProgramacionTipoNotificacionRepository>();
            //services.AddTransient<IPMTProgramacionUsuarioRepository, PMTProgramacionUsuarioRepository>();
            //services.AddTransient<IPMTResponsableUpdateRepository, PMTResponsableUpdateRepository>();
            //services.AddTransient<IPMTResponsableUpdate_CorreoRepository, PMTResponsableUpdate_CorreoRepository>();
            //services.AddTransient<IPPEFrecuenciaRepository, PPEFrecuenciaRepository>();
            //services.AddTransient<IProbabilidadRiesgoRepository, ProbabilidadRiesgoRepository>();
            //services.AddTransient<IProductoRepository, ProductoRepository>();
            //services.AddTransient<IProveedorRepository, ProveedorRepository>();
            //services.AddTransient<ISeveridadRiesgoRepository, SeveridadRiesgoRepository>();
            //services.AddTransient<ITipoCorreoRepository, TipoCorreoRepository>();
            //services.AddTransient<ITipoDireccionRepository, TipoDireccionRepository>();
            //services.AddTransient<ITipoEscalaRepository, TipoEscalaRepository>();
            //services.AddTransient<ITipoFrecuenciaRepository, TipoFrecuenciaRepository>();
            //services.AddTransient<ITipoImpactoRepository, TipoImpactoRepository>();
            //services.AddTransient<ITipoIncidenteRepository, TipoIncidenteRepository>();
            //services.AddTransient<ITipoInterdependenciaRepository, TipoInterdependenciaRepository>();
            //services.AddTransient<ITipoRespaldoRepository, TipoRespaldoRepository>();
            //services.AddTransient<ITipoResultadoPruebaRepository, TipoResultadoPruebaRepository>();
            //services.AddTransient<ITipoTablaContenidoRepository, TipoTablaContenidoRepository>();
            //services.AddTransient<ITipoTelefonoRepository, TipoTelefonoRepository>();
            //services.AddTransient<ITipoUbicacionInformacionRepository, TipoUbicacionInformacionRepository>();
            //services.AddTransient<IUnidadOrganizativaRepository, UnidadOrganizativaRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IUsuarioUnidadOrganizativaRepository, UsuarioUnidadOrganizativaRepository>();
            services.AddTransient<IVicepresidenciaRepository, VicepresidenciaRepository>();

            return services;
        }
    }
}
