using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAControlEventConfiguration : IEntityTypeConfiguration<BIAControlEvent>
    {
        public void Configure(EntityTypeBuilder<BIAControlEvent> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.ThreatId, e.ThreatEventId, e.ControlEventId });

            builder.ToTable("tblBIAEventoControl");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.ControlEventId).ValueGeneratedOnAdd();

            builder.Property(e => e.Description).IsRequired();

            builder.HasOne(d => d.BIAThreatEvent)
                .WithMany(p => p.BIAControlEvents)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId, d.ThreatId, d.ThreatEventId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIAEventoControl_tblBIAAmenazaEvento");
        }
    }
}
