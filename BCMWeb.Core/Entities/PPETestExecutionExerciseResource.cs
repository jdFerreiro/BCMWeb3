namespace BCMWeb.Core.Entities
{
    public partial class PPETestExecutionExerciseResource
    {
        public long CompanyId { get; set; }
        public long ScheduleId { get; set; }
        public long ExerciseId { get; set; }
        public long ResourceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Responsable { get; set; }

        public virtual PPETestExecutionExercise PPETestExecutionExerciseInfo { get; set; }
    }
}
