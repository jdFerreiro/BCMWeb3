using System.Collections.Generic;

namespace BCMWeb.Core.Entities
{
    public partial class PPETestScheduleParticipant
    {
        public PPETestScheduleParticipant()
        {
            PPETestScheduleExerciseParticipants = new HashSet<PPETestScheduleExerciseParticipant>();
        }

        public long CompanyId { get; set; }
        public long ScheduleId { get; set; }
        public long ParticipantId { get; set; }
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public bool Responsable { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public virtual PPETestSchedule PPETestScheduleInfo { get; set; }
        public virtual ICollection<PPETestScheduleExerciseParticipant> PPETestScheduleExerciseParticipants { get; set; }
    }
}
