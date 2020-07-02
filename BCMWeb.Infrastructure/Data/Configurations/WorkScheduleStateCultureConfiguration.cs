using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class WorkScheduleStateCultureConfiguration : IEntityTypeConfiguration<WorkScheduleStateCulture>
    {
        public void Configure(EntityTypeBuilder<WorkScheduleStateCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.WorkScheduleStateId });

            builder.ToTable("tblCultura_PlanTrabajoEstatus");

            builder.HasIndex(e => e.WorkScheduleStateId)
                .HasName("IX_FK_tblCultura_PlanTrabajoEstatus_tblPlanTrabajoEstatus");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(450);

            builder.HasOne(d => d.WorkScheduleStateInfo)
                .WithMany(p => p.WorkScheduleStateCultures)
                .HasForeignKey(d => d.WorkScheduleStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_PlanTrabajoEstatus_tblPlanTrabajoEstatus");
        }
    }
}
