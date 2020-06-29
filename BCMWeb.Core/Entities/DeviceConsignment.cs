using System;

namespace BCMWeb.Core.Entities
{
    public class DeviceConsignment : BaseEntity
    {
        public long DeviceId { get; set; }
        public long UserOwnerId { get; set; }
        public long CompanyId { get; set; }
        public long SubmoduleId { get; set; }
        public long UserConsignmentId { get; set; }
        public DateTime ConsignmentDate { get; set; }
        public DateTime? DownloadDate { get; set; }
        public bool? Downloaded { get; set; }

        public virtual CompanyMenuOption CompanyMenuOptionInfo { get; set; }
        public virtual Device DeviceInfo { get; set; }
        public virtual User UserConsingmentInfo { get; set; }
        public virtual User UserOwnerInfo { get; set; }
    }
}
