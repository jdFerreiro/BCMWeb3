using System;

namespace BCMWeb.Core.Entities
{
    public partial class Intiative
    {
        public long CompanyId { get; set; }
        public long IntiativeId { get; set; }
        public int? IntiativeNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long? OUId { get; set; }
        public string OUName { get; set; }
        public string ResponsableName { get; set; }
        public DateTime? ScheduleStartDate { get; set; }
        public DateTime? RealStartDate { get; set; }
        public DateTime? ScheduleEndDate { get; set; }
        public DateTime? RealEndDate { get; set; }
        public decimal? ScheduleBudget { get; set; }
        public decimal? RealBudget { get; set; }
        public short? IntiativeStatusId { get; set; }
        public string Comments { get; set; }
        public short? PriorityId { get; set; }
        public decimal? AmountPaid { get; set; }
        public decimal? AmountPending { get; set; }
        public decimal? ProgressPercentage { get; set; }
        public int? ScheduleHours { get; set; }
        public int? UsedHours { get; set; }

        public virtual IntitativePriority IntiativePriorityInfo { get; set; }
        public virtual Company CompanyInfo { get; set; }
        public virtual WorkScheduleState ScheduleWorkStatus { get; set; }
    }
}
