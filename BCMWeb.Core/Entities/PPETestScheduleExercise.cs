using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class PPETestScheduleExercise
    {
        public PPETestScheduleExercise()
        {
            PPETestScheduleExerciseParticipants = new HashSet<PPETestScheduleExerciseParticipant>();
            PPETestScheduleExerciseResources = new HashSet<PPETestScheduleExerciseResource>();
        }

        public long CompanyId { get; set; }
        public long ScheduleId { get; set; }
        public long ExerciseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int DurationHours { get; set; }
        public int DurationMinutes { get; set; }

        public virtual PPETestSchedule PPETestScheduleInfo { get; set; }
        public virtual ICollection<PPETestScheduleExerciseParticipant> PPETestScheduleExerciseParticipants { get; set; }
        public virtual ICollection<PPETestScheduleExerciseResource> PPETestScheduleExerciseResources { get; set; }
    }
}
