using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PPETestScheduleExerciseConfiguration : IEntityTypeConfiguration<PPETestScheduleExercise>
    {
        public void Configure(EntityTypeBuilder<PPETestScheduleExercise> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ExerciseId });

            builder.ToTable("tblPBEPruebaPlanificacionEjercicio");

            builder.Property(e => e.ExerciseId).ValueGeneratedOnAdd();

            builder.Property(e => e.Description).IsRequired();

            builder.Property(e => e.StartDate).HasColumnType("datetime");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(500);

            builder.HasOne(d => d.PPETestScheduleInfo)
                .WithMany(p => p.PPETestScheduleExercises)
                .HasForeignKey(d => new { d.CompanyId, d.ScheduleId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPBEPruebaPlanificacionEjercicio_tblPBEPruebaPlanificacion");
        }
    }
}
