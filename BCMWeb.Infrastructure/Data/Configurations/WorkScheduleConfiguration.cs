using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class WorkScheduleConfiguration : IEntityTypeConfiguration<WorkSchedule>
    {
        public void Configure(EntityTypeBuilder<WorkSchedule> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ActionId, e.ActivityId });

            builder.ToTable("tblPlanTrabajo");

            builder.HasIndex(e => e.Executed)
                .HasName("IX_FK_tblPlanTrabajo_tblPlanTrabajoEstatus");

            builder.Property(e => e.ActivityId).ValueGeneratedOnAdd();

            builder.Property(e => e.ExecutionProposalDate).HasColumnType("datetime");

            builder.Property(e => e.Recommendation)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.Responsable)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.WorkScheduleStateInfo)
                .WithMany(p => p.WorkSchedules)
                .HasForeignKey(d => d.Executed)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPlanTrabajo_tblPlanTrabajoEstatus");

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.WorkSchedules)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPlanTrabajo_tblEmpresa");

            builder.HasOne(d => d.WorkScheduleActionInfo)
                .WithMany(p => p.WorkSchedules)
                .HasForeignKey(d => new { d.CompanyId, d.ActionId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPlanTrabajo_tblPlanTrabajoAccion");
        }
    }
}
