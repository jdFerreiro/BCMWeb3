using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIASecondaryBackupConfiguration : IEntityTypeConfiguration<BIASecondaryBackup>
    {
        public void Configure(EntityTypeBuilder<BIASecondaryBackup> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIAocumentId, e.ProcessId, e.BackupId });

            builder.ToTable("tblBIARespaldoSecundario");

            builder.Property(e => e.BIAocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.BackupId).ValueGeneratedOnAdd();

            builder.Property(e => e.Location)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIAScondaryBackups)
                .HasForeignKey(d => new { d.CompanyId, d.BIAocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIARespaldoSecundario_tblBIAProceso");
        }
    }
}
