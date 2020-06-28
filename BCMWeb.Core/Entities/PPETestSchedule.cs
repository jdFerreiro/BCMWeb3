using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class PPETestSchedule
    {
        public PPETestSchedule()
        {
            PPETestScheduleExercises = new HashSet<PPETestScheduleExercise>();
            PPETestScheduleExerciseResources = new HashSet<PPETestScheduleExerciseResource>();
            PPETestScheduleParticipants = new HashSet<PPETestScheduleParticipant>();
        }

        public long CompanyId { get; set; }
        public long ScheduleId { get; set; }
        public bool ForBussiness { get; set; }
        public string Test { get; set; }
        public string Purpose { get; set; }
        public DateTime StartDate { get; set; }
        public string Location { get; set; }
        public short? StatusId { get; set; }

        public virtual Company CompanyInfo { get; set; }
        public virtual PPETestExecution PPETestExecutionInfo { get; set; }
        public virtual ICollection<PPETestScheduleExercise> PPETestScheduleExercises { get; set; }
        public virtual ICollection<PPETestScheduleExerciseResource> PPETestScheduleExerciseResources { get; set; }
        public virtual ICollection<PPETestScheduleParticipant> PPETestScheduleParticipants { get; set; }
    }
}
