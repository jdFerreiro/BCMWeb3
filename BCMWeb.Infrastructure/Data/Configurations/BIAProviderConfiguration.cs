using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAProviderConfiguration : IEntityTypeConfiguration<BIAProvider>
    {
        public void Configure(EntityTypeBuilder<BIAProvider> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.ProviderId });

            builder.ToTable("tblBIAProveedor");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.ProviderId).ValueGeneratedOnAdd();

            builder.Property(e => e.Contact)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.Organization)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.Service)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIAProviders)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIAProveedor_tblBIAProceso");
        }
    }
}
