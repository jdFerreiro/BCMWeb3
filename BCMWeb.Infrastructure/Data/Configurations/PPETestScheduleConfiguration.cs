using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PPETestScheduleConfiguration : IEntityTypeConfiguration<PPETestSchedule>
    {
        public void Configure(EntityTypeBuilder<PPETestSchedule> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ScheduleId });

            builder.ToTable("tblPBEPruebaPlanificacion");

            builder.Property(e => e.ScheduleId).ValueGeneratedOnAdd();

            builder.Property(e => e.StartDate).HasColumnType("datetime");

            builder.Property(e => e.Location)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(e => e.Purpose).IsRequired();

            builder.Property(e => e.Test)
                .IsRequired()
                .HasMaxLength(500);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.PPETestPlannings)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPBEPruebaPlanificacion_tblEmpresa");
        }
    }
}
