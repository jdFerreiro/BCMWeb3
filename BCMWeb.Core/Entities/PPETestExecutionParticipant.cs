using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public class PPETestExecutionParticipant : BaseEntity
    {
        public PPETestExecutionParticipant()
        {
            PPETestExecutionExerciceParticipants = new HashSet<PPETestExecutionExerciseParticipant>();
        }

        public long CompanyId { get; set; }
        public long ScheduleId { get; set; }
        public long ParticipantId { get; set; }
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public bool IsResponsable { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public long ScheduleParticipantId { get; set; }

        public virtual PPETestExecution PPEExecutionTestInfo { get; set; }
        public virtual ICollection<PPETestExecutionExerciseParticipant> PPETestExecutionExerciceParticipants { get; set; }
    }
}
