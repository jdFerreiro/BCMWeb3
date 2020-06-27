using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class TblEmpresa
    {
        public TblEmpresa()
        {
            TblAuditoria = new HashSet<TblAuditoria>();
            TblAuditoriaProcesoCritico = new HashSet<TblAuditoriaProcesoCritico>();
            TblBcpdocumento = new HashSet<TblBcpdocumento>();
            TblBiacadenaServicio = new HashSet<TblBiacadenaServicio>();
            TblBiadocumento = new HashSet<TblBiadocumento>();
            TblBiaunidadTrabajo = new HashSet<TblBiaunidadTrabajo>();
            TblCargo = new HashSet<TblCargo>();
            TblCriticidad = new HashSet<TblCriticidad>();
            TblDispositivoConexion = new HashSet<TblDispositivoConexion>();
            TblDispositivoConexion1 = new HashSet<TblDispositivoConexion1>();
            TblDocumento = new HashSet<TblDocumento>();
            TblDocumentoPersonaClave = new HashSet<TblDocumentoPersonaClave>();
            TblEmpresaModulo = new HashSet<TblEmpresaModulo>();
            TblEmpresaUsuario = new HashSet<TblEmpresaUsuario>();
            TblEscala = new HashSet<TblEscala>();
            TblFormatosEmail = new HashSet<TblFormatosEmail>();
            TblIncidentes = new HashSet<TblIncidentes>();
            TblIniciativas = new HashSet<TblIniciativas>();
            TblIniciativasAnexo = new HashSet<TblIniciativasAnexo>();
            TblLocalidad = new HashSet<TblLocalidad>();
            TblModulo = new HashSet<TblModulo>();
            TblModuloAnexo = new HashSet<TblModuloAnexo>();
            TblModuloNivelUsuario = new HashSet<TblModuloNivelUsuario>();
            TblPbepruebaEjecucion = new HashSet<TblPbepruebaEjecucion>();
            TblPbepruebaEjecucionEjercicio = new HashSet<TblPbepruebaEjecucionEjercicio>();
            TblPbepruebaPlanificacion = new HashSet<TblPbepruebaPlanificacion>();
            TblPersona = new HashSet<TblPersona>();
            TblPlanTrabajo = new HashSet<TblPlanTrabajo>();
            TblPlanTrabajoAccion = new HashSet<TblPlanTrabajoAccion>();
            TblPmtmensajeActualizacion = new HashSet<TblPmtmensajeActualizacion>();
            TblPmtprogramacion = new HashSet<TblPmtprogramacion>();
            TblPmtresponsableUpdate = new HashSet<TblPmtresponsableUpdate>();
            TblProbabilidadRiesgo = new HashSet<TblProbabilidadRiesgo>();
            TblProducto = new HashSet<TblProducto>();
            TblProveedor = new HashSet<TblProveedor>();
            TblUnidadOrganizativa = new HashSet<TblUnidadOrganizativa>();
            TblUsuarioUnidadOrganizativa = new HashSet<TblUsuarioUnidadOrganizativa>();
            TblVicepresidencia = new HashSet<TblVicepresidencia>();
        }

        public long IdEmpresa { get; set; }
        public string NombreFiscal { get; set; }
        public string RegistroFiscal { get; set; }
        public string NombreComercial { get; set; }
        public string DireccionAdministrativa { get; set; }
        public long IdEstado { get; set; }
        public DateTime FechaUltimoEstado { get; set; }
        public string LogoUrl { get; set; }
        public DateTime FechaInicioActividad { get; set; }
        public bool? CrearProcesos { get; set; }
        public bool? CrearUnidadOrganizativa { get; set; }
        public bool? CrearUnidadTrabajo { get; set; }
        public bool? CrearAplicaciones { get; set; }
        public bool? CrearDocumento { get; set; }
        public long? IdPais { get; set; }
        public long? IdPaisEstado { get; set; }
        public long? IdPaisEstadoCiudad { get; set; }

        public virtual TblEstadoEmpresa IdEstadoNavigation { get; set; }
        public virtual TblEstado IdPais1 { get; set; }
        public virtual TblCiudad IdPais2 { get; set; }
        public virtual TblPais IdPaisNavigation { get; set; }
        public virtual ICollection<TblAuditoria> TblAuditoria { get; set; }
        public virtual ICollection<TblAuditoriaProcesoCritico> TblAuditoriaProcesoCritico { get; set; }
        public virtual ICollection<TblBcpdocumento> TblBcpdocumento { get; set; }
        public virtual ICollection<TblBiacadenaServicio> TblBiacadenaServicio { get; set; }
        public virtual ICollection<TblBiadocumento> TblBiadocumento { get; set; }
        public virtual ICollection<TblBiaunidadTrabajo> TblBiaunidadTrabajo { get; set; }
        public virtual ICollection<TblCargo> TblCargo { get; set; }
        public virtual ICollection<TblCriticidad> TblCriticidad { get; set; }
        public virtual ICollection<TblDispositivoConexion> TblDispositivoConexion { get; set; }
        public virtual ICollection<TblDispositivoConexion1> TblDispositivoConexion1 { get; set; }
        public virtual ICollection<TblDocumento> TblDocumento { get; set; }
        public virtual ICollection<TblDocumentoPersonaClave> TblDocumentoPersonaClave { get; set; }
        public virtual ICollection<TblEmpresaModulo> TblEmpresaModulo { get; set; }
        public virtual ICollection<TblEmpresaUsuario> TblEmpresaUsuario { get; set; }
        public virtual ICollection<TblEscala> TblEscala { get; set; }
        public virtual ICollection<TblFormatosEmail> TblFormatosEmail { get; set; }
        public virtual ICollection<TblIncidentes> TblIncidentes { get; set; }
        public virtual ICollection<TblIniciativas> TblIniciativas { get; set; }
        public virtual ICollection<TblIniciativasAnexo> TblIniciativasAnexo { get; set; }
        public virtual ICollection<TblLocalidad> TblLocalidad { get; set; }
        public virtual ICollection<TblModulo> TblModulo { get; set; }
        public virtual ICollection<TblModuloAnexo> TblModuloAnexo { get; set; }
        public virtual ICollection<TblModuloNivelUsuario> TblModuloNivelUsuario { get; set; }
        public virtual ICollection<TblPbepruebaEjecucion> TblPbepruebaEjecucion { get; set; }
        public virtual ICollection<TblPbepruebaEjecucionEjercicio> TblPbepruebaEjecucionEjercicio { get; set; }
        public virtual ICollection<TblPbepruebaPlanificacion> TblPbepruebaPlanificacion { get; set; }
        public virtual ICollection<TblPersona> TblPersona { get; set; }
        public virtual ICollection<TblPlanTrabajo> TblPlanTrabajo { get; set; }
        public virtual ICollection<TblPlanTrabajoAccion> TblPlanTrabajoAccion { get; set; }
        public virtual ICollection<TblPmtmensajeActualizacion> TblPmtmensajeActualizacion { get; set; }
        public virtual ICollection<TblPmtprogramacion> TblPmtprogramacion { get; set; }
        public virtual ICollection<TblPmtresponsableUpdate> TblPmtresponsableUpdate { get; set; }
        public virtual ICollection<TblProbabilidadRiesgo> TblProbabilidadRiesgo { get; set; }
        public virtual ICollection<TblProducto> TblProducto { get; set; }
        public virtual ICollection<TblProveedor> TblProveedor { get; set; }
        public virtual ICollection<TblUnidadOrganizativa> TblUnidadOrganizativa { get; set; }
        public virtual ICollection<TblUsuarioUnidadOrganizativa> TblUsuarioUnidadOrganizativa { get; set; }
        public virtual ICollection<TblVicepresidencia> TblVicepresidencia { get; set; }
    }
}
