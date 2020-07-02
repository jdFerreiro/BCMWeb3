using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAThreatEventConfiguration : IEntityTypeConfiguration<BIAThreatEvent>
    {
        public void Configure(EntityTypeBuilder<BIAThreatEvent> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.ThreatId, e.ThreatEventId });

            builder.ToTable("tblBIAAmenazaEvento");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.ThreatEventId).ValueGeneratedOnAdd();

            builder.Property(e => e.Name).IsRequired();
        }
    }
}
