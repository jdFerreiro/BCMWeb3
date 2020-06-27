using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class User
    {
        public User()
        {
            Audits = new HashSet<TblAuditoria>();
            AuditCriticalProcesses = new HashSet<TblAuditoriaProcesoCritico>();
            MobileDevices = new HashSet<TblDispositivo1>();
            MobileDeviceConnections = new HashSet<TblDispositivoConexion>();
            MobileDeviceSendsByUserId = new HashSet<TblDispositivoEnvio1>();
            MobileDeviceReceivesByUserId = new HashSet<TblDispositivoEnvio1>();
            Companies = new HashSet<TblEmpresaUsuario>();
            MenuOptions = new HashSet<TblModuloUsuario>();
            Persons = new HashSet<TblPersona>();
            WorkPlannAudits = new HashSet<TblPlanTrabajoAuditoria>();
            MaintenancePlanSchedules = new HashSet<TblPmtprogramacionUsuario>();
            MaintenancePlanUpdateEmails = new HashSet<TblPmtresponsableUpdateCorreo>();
            OrganizationUnits = new HashSet<TblUsuarioUnidadOrganizativa>();
        }

        public long UserId { get; set; }
        public string UserCode { get; set; }
        public string UserPassw { get; set; }
        public string Name { get; set; }
        public short UserStateId { get; set; }
        public DateTime? UserStateDateChange { get; set; }
        public DateTime? LastConnectionDate { get; set; }
        public bool? FirstTime { get; set; }
        public string Email { get; set; }

        public virtual TblEstadoUsuario UserStateNavigation { get; set; }
        public virtual ICollection<TblAuditoria> Audits { get; set; }
        public virtual ICollection<TblAuditoriaProcesoCritico> AuditCriticalProcesses { get; set; }
        public virtual ICollection<TblDispositivo1> MobileDevices { get; set; }
        public virtual ICollection<TblDispositivoConexion> MobileDeviceConnections { get; set; }
        public virtual ICollection<TblDispositivoEnvio1> MobileDeviceSendsByUserId { get; set; }
        public virtual ICollection<TblDispositivoEnvio1> MobileDeviceReceivesByUserId { get; set; }
        public virtual ICollection<TblEmpresaUsuario> Companies { get; set; }
        public virtual ICollection<TblModuloUsuario> MenuOptions { get; set; }
        public virtual ICollection<TblPersona> Persons { get; set; }
        public virtual ICollection<TblPlanTrabajoAuditoria> WorkPlannAudits { get; set; }
        public virtual ICollection<TblPmtprogramacionUsuario> MaintenancePlanSchedules { get; set; }
        public virtual ICollection<TblPmtresponsableUpdateCorreo> MaintenancePlanUpdateEmails { get; set; }
        public virtual ICollection<TblUsuarioUnidadOrganizativa> OrganizationUnits { get; set; }
    }
}
