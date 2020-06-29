using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class PMTSchedule : BaseEntity
    {
        public PMTSchedule()
        {
            PMTScheduleDocuments = new HashSet<PMTScheduleDocument>();
            PMTScheduleUsers = new HashSet<PMTScheduleUser>();
        }

        public long PMTScheduleId { get; set; }
        public long CompanyId { get; set; }
        public long MenuOptionId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public long PMTScheduleStateId { get; set; }
        public bool ForBussiness { get; set; }
        public short UpdateTypeId { get; set; }
        public long FrecuencyTypeId { get; set; }

        public virtual MenuOption MenuOptionInfo { get; set; }
        public virtual Company CompanyIdInfo { get; set; }
        public virtual PMTScheduleUpdateType UpdateTypeInfo { get; set; }
        public virtual FrecuencyType FrecuencyTypeInfo { get; set; }
        public virtual ICollection<PMTScheduleDocument> PMTScheduleDocuments { get; set; }
        public virtual ICollection<PMTScheduleUser> PMTScheduleUsers { get; set; }
    }
}
