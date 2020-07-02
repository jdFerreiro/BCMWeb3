using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class WorkScheduleAuditConfiguration : IEntityTypeConfiguration<WorkScheduleAudit>
    {
        public void Configure(EntityTypeBuilder<WorkScheduleAudit> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ActionId, e.ActivityId, e.StateChangeId });

            builder.ToTable("tblPlanTrabajoAuditoria");

            builder.HasIndex(e => e.State)
                .HasName("IX_FK_tblPlanTrabajoAuditoria_tblPlanTrabajoEstatus");

            builder.HasIndex(e => e.StateChangeUserId)
                .HasName("IX_FK_tblPlanTrabajoAuditoria_tblUsuario");

            builder.Property(e => e.StateChangeId).ValueGeneratedOnAdd();

            builder.Property(e => e.StateChangeDate).HasColumnType("datetime");

            builder.HasOne(d => d.WorkScheduleStateInfo)
                .WithMany(p => p.WorkScheduleAudits)
                .HasForeignKey(d => d.State)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPlanTrabajoAuditoria_tblPlanTrabajoEstatus");

            builder.HasOne(d => d.UserInfo)
                .WithMany(p => p.WorkPlannAudits)
                .HasForeignKey(d => d.StateChangeUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPlanTrabajoAuditoria_tblUsuario");

            builder.HasOne(d => d.WorkScheduleActionInfo)
                .WithMany(p => p.WorkScheduleAudits)
                .HasForeignKey(d => new { d.CompanyId, d.ActionId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPlanTrabajoAuditoria_tblPlanTrabajoAccion");

            builder.HasOne(d => d.WorkScheduleInfo)
                .WithMany(p => p.WorkScheduleAudits)
                .HasForeignKey(d => new { d.CompanyId, d.ActionId, d.ActivityId })
                .HasConstraintName("FK_tblPlanTrabajoAuditoria_tblPlanTrabajo");
        }
    }
}
