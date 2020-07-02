using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class IntiativeConfiguration : IEntityTypeConfiguration<Intiative>
    {
        public void Configure(EntityTypeBuilder<Intiative> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.IntiativeId });

            builder.ToTable("tblIniciativas");

            builder.HasIndex(e => e.IntiativeStatusId)
                .HasName("IX_FK_tblIniciativas_tblPlanTrabajoEstatus");

            builder.HasIndex(e => new { e.CompanyId, e.PriorityId })
                .HasName("IX_FK_tblIniciativas_tblIniciativaPrioridad");

            builder.Property(e => e.IntiativeId).ValueGeneratedOnAdd();

            builder.Property(e => e.ScheduleEndDate).HasColumnType("datetime");

            builder.Property(e => e.RealEndDate).HasColumnType("datetime");

            builder.Property(e => e.ScheduleStartDate).HasColumnType("datetime");

            builder.Property(e => e.RealStartDate).HasColumnType("datetime");

            builder.Property(e => e.AmountPaid).HasColumnType("decimal(19, 4)");

            builder.Property(e => e.AmountPending).HasColumnType("decimal(19, 4)");

            builder.Property(e => e.Name).HasMaxLength(1500);

            builder.Property(e => e.ResponsableName).HasMaxLength(1500);

            builder.Property(e => e.ProgressPercentage).HasColumnType("decimal(5, 2)");

            builder.Property(e => e.ScheduleBudget).HasColumnType("decimal(19, 4)");

            builder.Property(e => e.RealBudget).HasColumnType("decimal(19, 4)");

            builder.Property(e => e.OUName).HasMaxLength(1500);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.Initiatives)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblIniciativas_tblEmpresa");

            builder.HasOne(d => d.ScheduleWorkStatus)
                .WithMany(p => p.Intiatives)
                .HasForeignKey(d => d.IntiativeStatusId)
                .HasConstraintName("FK_tblIniciativas_tblPlanTrabajoEstatus");

            builder.HasOne(d => d.IntiativePriorityInfo)
                .WithMany(p => p.Intiatives)
                .HasForeignKey(d => new { d.CompanyId, d.PriorityId })
                .HasConstraintName("FK_tblIniciativas_tblIniciativaPrioridad");
        }
    }
}
