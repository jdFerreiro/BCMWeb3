﻿using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class PMTScheduleUpdateType
    {
        public PMTScheduleUpdateType()
        {
            PMTScheduleUpdateTypeCultures = new HashSet<PMTScheduleUpdateTypeCulture>();
            PMTSchedules = new HashSet<PMTSchedule>();
        }

        public short UpdateTypeId { get; set; }

        public virtual ICollection<PMTScheduleUpdateTypeCulture> PMTScheduleUpdateTypeCultures { get; set; }
        public virtual ICollection<PMTSchedule> PMTSchedules { get; set; }
    }
}
