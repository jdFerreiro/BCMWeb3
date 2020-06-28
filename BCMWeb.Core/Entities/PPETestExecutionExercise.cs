using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class PPETestExecutionExercise
    {
        public PPETestExecutionExercise()
        {
            PPETestExecutionExerciceParticipants = new HashSet<PPETestExecutionExerciseParticipant>();
            PPETestExecutionExerciseResources = new HashSet<PPETestExecutionExerciseResource>();
        }

        public long CompanyId { get; set; }
        public long ScheduleId { get; set; }
        public long ExerciseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int DurationHours { get; set; }
        public int DurationMinutes { get; set; }
        public short? StatusId { get; set; }
        public long ScheduleExerciseId { get; set; }

        public virtual PPETestExecution PPEExecutionTestInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
        public virtual PPETestStatus PPETestStatusInfo { get; set; }
        public virtual ICollection<PPETestExecutionExerciseParticipant> PPETestExecutionExerciceParticipants { get; set; }
        public virtual ICollection<PPETestExecutionExerciseResource> PPETestExecutionExerciseResources { get; set; }
    }
}
