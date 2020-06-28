namespace BCMWeb.Core.Entities
{
    public partial class PPETestExecutionExerciseParticipant
    {
        public long CompanyId { get; set; }
        public long ScheduleId { get; set; }
        public long ExerciseId { get; set; }
        public long ParticipantId { get; set; }
        public bool Responsable { get; set; }

        public virtual PPETestExecutionExercise PPETestExecutionExerciseInfo { get; set; }
        public virtual PPETestExecutionParticipant PPETestExecutionParticipantInfo { get; set; }
    }
}
