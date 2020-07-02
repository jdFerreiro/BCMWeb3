using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PPETestExecutionParticipantConfiguration : IEntityTypeConfiguration<PPETestExecutionParticipant>
    {
        public void Configure(EntityTypeBuilder<PPETestExecutionParticipant> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ScheduleId, e.ParticipantId });

            builder.ToTable("tblPBEPruebaEjecucionParticipante");

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

            builder.HasOne(d => d.PPEExecutionTestInfo)
                .WithMany(p => p.PPETestExecutionParticipants)
                .HasForeignKey(d => new { d.CompanyId, d.ScheduleId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPBEPruebaEjecucionParticipante_tblPBEPruebaEjecucion");
        }
    }
}
