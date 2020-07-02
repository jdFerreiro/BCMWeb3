using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAAlternateProcessConfiguration : IEntityTypeConfiguration<BIAAlternateProcess>
    {
        public void Configure(EntityTypeBuilder<BIAAlternateProcess> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.AlternateProcessId });

            builder.ToTable("tblBIAProcesoAlterno");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.AlternateProcessId).ValueGeneratedOnAdd();

            builder.Property(e => e.AlternateProcess).IsRequired();

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIAAlternateProcesses)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIAProcesoAlterno_tblBIAProceso");
        }
    }
}
