using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class WorkScheduleStateConfiguration : IEntityTypeConfiguration<WorkScheduleState>
    {
        public void Configure(EntityTypeBuilder<WorkScheduleState> builder)
        {
            builder.HasKey(e => e.WorkScheduleStateId);

            builder.ToTable("tblPlanTrabajoEstatus");

            builder.Property(e => e.WorkScheduleStateId).ValueGeneratedNever();
        }
    }
}
