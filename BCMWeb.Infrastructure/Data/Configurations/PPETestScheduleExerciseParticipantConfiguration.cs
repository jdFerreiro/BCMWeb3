using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PPETestScheduleExerciseParticipantConfiguration : IEntityTypeConfiguration<PPETestScheduleExerciseParticipant>
    {
        public void Configure(EntityTypeBuilder<PPETestScheduleExerciseParticipant> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ExerciseId, e.ParticipantId });

            builder.ToTable("tblPBEPruebaPlanificacionEjercicioParticipante");

            builder.HasIndex(e => new { e.CompanyId, e.ScheduleId, e.ParticipantId })
                .HasName("IX_FK_tblPBEPruebaPlanificacionEjercicioParticipante_tblPBEPruebaPlanificacionParticipante");

            builder.HasOne(d => d.PPETestScheduleExerciseInfo)
                .WithMany(p => p.PPETestScheduleExerciseParticipants)
                .HasForeignKey(d => new { d.CompanyId, d.ScheduleId, d.ExerciseId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPBEPruebaPlanificacionEjercicioParticipante_tblPBEPruebaPlanificacionEjercicio");

            builder.HasOne(d => d.PPETestScheduleParticipantInfo)
                .WithMany(p => p.PPETestScheduleExerciseParticipants)
                .HasForeignKey(d => new { d.CompanyId, d.ScheduleId, d.ParticipantId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPBEPruebaPlanificacionEjercicioParticipante_tblPBEPruebaPlanificacionParticipante");
        }
    }
}
