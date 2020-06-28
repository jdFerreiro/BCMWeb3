using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class Device
    {
        public Device()
        {
            DeviceConnections = new HashSet<DeviceConnection>();
            DeviceConsignments = new HashSet<DeviceConsignment>();
        }

        public long DeviceId { get; set; }
        public long UserOwnerId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string IMEI { get; set; }
        public string Name { get; set; }
        public string MakerName { get; set; }
        public string Model { get; set; }
        public string Platform { get; set; }
        public string Version { get; set; }
        public string DeviceType { get; set; }
        public string DeviceToken { get; set; }

        public virtual User UserInfo { get; set; }
        public virtual ICollection<DeviceConnection> DeviceConnections { get; set; }
        public virtual ICollection<DeviceConsignment> DeviceConsignments { get; set; }
    }
}
