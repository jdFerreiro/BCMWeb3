using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PPETestExecutionExerciseResourceConfiguration : IEntityTypeConfiguration<PPETestExecutionExerciseResource>
    {
        public void Configure(EntityTypeBuilder<PPETestExecutionExerciseResource> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ExerciseId, e.ResourceId });

            builder.ToTable("tblPBEPruebaEjecucionEjercicioRecurso");

            builder.Property(e => e.ResourceId).ValueGeneratedOnAdd();

            builder.Property(e => e.Description).IsRequired();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.Responsable)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne(d => d.PPETestExecutionExerciseInfo)
                .WithMany(p => p.PPETestExecutionExerciseResources)
                .HasForeignKey(d => new { d.CompanyId, d.ScheduleId, d.ExerciseId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicioRecurso_tblPBEPruebaEjecucionEjercicio");
        }
    }
}
