namespace BCMWeb.Core.Entities
{
    public class PPETestScheduleExerciseParticipant : BaseEntity
    {
        public long CompanyId { get; set; }
        public long ScheduleId { get; set; }
        public long ExerciseId { get; set; }
        public long ParticipantId { get; set; }
        public bool Responsable { get; set; }

        public virtual PPETestScheduleExercise PPETestScheduleExerciseInfo { get; set; }
        public virtual PPETestScheduleParticipant PPETestScheduleParticipantInfo { get; set; }
    }
}
