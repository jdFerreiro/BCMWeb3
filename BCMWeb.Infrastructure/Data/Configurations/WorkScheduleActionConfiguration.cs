using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class WorkScheduleActionConfiguration : IEntityTypeConfiguration<WorkScheduleAction>
    {
        public void Configure(EntityTypeBuilder<WorkScheduleAction> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ScheduleActionId });

            builder.ToTable("tblPlanTrabajoAccion");

            builder.Property(e => e.ScheduleActionId).ValueGeneratedOnAdd();

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.WorkScheduleActions)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPlanTrabajoAccion_tblEmpresa");
        }
    }
}
