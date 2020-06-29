using System;
using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class PPETestExecution : BaseEntity
    {
        public PPETestExecution()
        {
            PPETestExecutionExercises = new HashSet<PPETestExecutionExercise>();
            PPETestExecutionParticipants = new HashSet<PPETestExecutionParticipant>();
            PPETestExecutionResult = new HashSet<PPETestExecutionResult>();
        }

        public long CountryId { get; set; }
        public long ScheduleId { get; set; }
        public DateTime StartDate { get; set; }
        public string LocationName { get; set; }

        public virtual PPETestSchedule PPETestScheduleInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
        public virtual ICollection<PPETestExecutionExercise> PPETestExecutionExercises { get; set; }
        public virtual ICollection<PPETestExecutionParticipant> PPETestExecutionParticipants { get; set; }
        public virtual ICollection<PPETestExecutionResult> PPETestExecutionResult { get; set; }
    }
}
