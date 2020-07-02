using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PPETestScheduleParticipantConfiguration : IEntityTypeConfiguration<PPETestScheduleParticipant>
    {
        public void Configure(EntityTypeBuilder<PPETestScheduleParticipant> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ParticipantId });

            builder.ToTable("tblPBEPruebaPlanificacionParticipante");

            builder.Property(e => e.ParticipantId).ValueGeneratedOnAdd();

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(e => e.CompanyName)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasOne(d => d.PPETestScheduleInfo)
                .WithMany(p => p.PPETestScheduleParticipants)
                .HasForeignKey(d => new { d.CompanyId, d.ScheduleId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPBEPruebaPlanificacionParticipante_tblPBEPruebaPlanificacion");
        }
    }
}
