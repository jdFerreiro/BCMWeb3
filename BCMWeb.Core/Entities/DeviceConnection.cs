using System;

namespace BCMWeb.Core.Entities
{
    public partial class DeviceConnection
    {
        public long DeviceId { get; set; }
        public long UserOwnerId { get; set; }
        public DateTime ConnectionDate { get; set; }
        public long? CompanyId { get; set; }
        public long? MenuOptionId { get; set; }
        public string IPAddress { get; set; }

        public virtual Device DeviceInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
    }
}
