using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PPETestScheduleExerciseResourceConfiguration : IEntityTypeConfiguration<PPETestScheduleExerciseResource>
    {
        public void Configure(EntityTypeBuilder<PPETestScheduleExerciseResource> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ExerciseId, e.ResourceId });

            builder.ToTable("tblPBEPruebaPlanificacionEjercicioRecurso");

            builder.Property(e => e.ResourceId).ValueGeneratedOnAdd();

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.Responsable)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne(d => d.PPETestScheduleInfo)
                .WithMany(p => p.PPETestScheduleExerciseResources)
                .HasForeignKey(d => new { d.CompanyId, d.ScheduleId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPBEPruebaPlanificacionRecurso_tblPBEPruebaPlanificacion");

            builder.HasOne(d => d.PPETestScheduleExercise)
                .WithMany(p => p.PPETestScheduleExerciseResources)
                .HasForeignKey(d => new { d.CompanyId, d.ScheduleId, d.ExerciseId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPBEPruebaPlanificacionEjercicioRecurso_tblPBEPruebaPlanificacionEjercicio");
        }
    }
}
