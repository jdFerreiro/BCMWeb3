﻿namespace BCMWeb.Core.Entities
{
    public class PPETestScheduleExerciseResource : BaseEntity
    {
        public long CompanyId { get; set; }
        public long ScheduleId { get; set; }
        public long ExerciseId { get; set; }
        public long ResourceId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Responsable { get; set; }

        public virtual PPETestSchedule PPETestScheduleInfo { get; set; }
        public virtual PPETestScheduleExercise PPETestScheduleExercise { get; set; }
    }
}
