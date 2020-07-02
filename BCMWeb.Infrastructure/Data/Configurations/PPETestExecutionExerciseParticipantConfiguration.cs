using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PPETestExecutionExerciseParticipantConfiguration : IEntityTypeConfiguration<PPETestExecutionExerciseParticipant>
    {
        public void Configure(EntityTypeBuilder<PPETestExecutionExerciseParticipant> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ExerciseId, e.ParticipantId });

            builder.ToTable("tblPBEPruebaEjecucionEjercicioParticipante");

            builder.HasIndex(e => new { e.CompanyId, e.ScheduleId, e.ParticipantId })
                .HasName("IX_FK_tblPBEPruebaEjecucionEjercicioParticipante_tblPBEPruebaEjecucionParticipante");

            builder.HasOne(d => d.PPETestExecutionExerciseInfo)
                .WithMany(p => p.PPETestExecutionExerciceParticipants)
                .HasForeignKey(d => new { d.CompanyId, d.ScheduleId, d.ExerciseId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicioParticipante_tblPBEPruebaEjecucionEjercicio");

            builder.HasOne(d => d.PPETestExecutionParticipantInfo)
                .WithMany(p => p.PPETestExecutionExerciceParticipants)
                .HasForeignKey(d => new { d.CompanyId, d.ScheduleId, d.ParticipantId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPBEPruebaEjecucionEjercicioParticipante_tblPBEPruebaEjecucionParticipante");
        }
    }
}
