using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAPrimaryBackupConfiguration : IEntityTypeConfiguration<BIAPrimaryBackup>
    {
        public void Configure(EntityTypeBuilder<BIAPrimaryBackup> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.BackupId });

            builder.ToTable("tblBIARespaldoPrimario");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.BackupId).ValueGeneratedOnAdd();

            builder.Property(e => e.Location)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIAPrimaryBackups)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIARespaldoPrimario_tblBIAProceso");
        }
    }
}
