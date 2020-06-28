using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class User
    {
        public User()
        {
            Audits = new HashSet<Audit>();
            CriticalProcessAudit = new HashSet<AuditCriticalProcess>();
            MobileDevices = new HashSet<Device>();
            MobileDeviceConnections = new HashSet<DeviceConnection>();
            MobileDeviceSendsByUser = new HashSet<DeviceConsignment>();
            MobileDeviceReceivesByUser = new HashSet<DeviceConsignment>();
            Companies = new HashSet<UserCompany>();
            MenuOptions = new HashSet<UserMenuOption>();
            Persons = new HashSet<Person>();
            WorkPlannAudits = new HashSet<WorkScheduleAudit>();
            MaintenancePlanSchedules = new HashSet<PMTScheduleUser>();
            MaintenancePlanUpdateEmails = new HashSet<PMTUpdateResponsableEmail>();
            OrganizationUnits = new HashSet<UserOrganizationUnit>();
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

        public virtual UserState UserStateInfo { get; set; }
        public virtual ICollection<Audit> Audits { get; set; }
        public virtual ICollection<AuditCriticalProcess> CriticalProcessAudit { get; set; }
        public virtual ICollection<Device> MobileDevices { get; set; }
        public virtual ICollection<DeviceConnection> MobileDeviceConnections { get; set; }
        public virtual ICollection<DeviceConsignment> MobileDeviceSendsByUser { get; set; }
        public virtual ICollection<DeviceConsignment> MobileDeviceReceivesByUser { get; set; }
        public virtual ICollection<UserCompany> Companies { get; set; }
        public virtual ICollection<UserMenuOption> MenuOptions { get; set; }
        public virtual ICollection<Person> Persons { get; set; }
        public virtual ICollection<WorkScheduleAudit> WorkPlannAudits { get; set; }
        public virtual ICollection<PMTScheduleUser> MaintenancePlanSchedules { get; set; }
        public virtual ICollection<PMTUpdateResponsableEmail> MaintenancePlanUpdateEmails { get; set; }
        public virtual ICollection<UserOrganizationUnit> OrganizationUnits { get; set; }
    }
}
