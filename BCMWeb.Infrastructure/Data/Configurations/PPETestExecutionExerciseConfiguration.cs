using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PPETestExecutionExerciseConfiguration : IEntityTypeConfiguration<PPETestExecutionExercise>
    {
        public void Configure(EntityTypeBuilder<PPETestExecutionExercise> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ExerciseId });

            builder.ToTable("tblPBEPruebaEjecucionEjercicio");

            builder.HasIndex(e => e.StatusId)
                .HasName("IX_FK_tblPBEPruebaEjecucionEjercicio_tblPBEPruebaEjecucionEstatus");

            builder.Property(e => e.ExerciseId).ValueGeneratedOnAdd();

            builder.Property(e => e.Description).IsRequired();

            builder.Property(e => e.StartDate).HasColumnType("datetime");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(500);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.PPETestExecutionExersices)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicio_tblEmpresa");

            builder.HasOne(d => d.PPETestStatusInfo)
                .WithMany(p => p.PPETestExecutionExercises)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicio_tblPBEPruebaEjecucionEstatus");

            builder.HasOne(d => d.PPEExecutionTestInfo)
                .WithMany(p => p.PPETestExecutionExercises)
                .HasForeignKey(d => new { d.CompanyId, d.ScheduleId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicio_tblPBEPruebaEjecucion");
        }
    }
}
