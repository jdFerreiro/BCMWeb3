using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAProcessClientConfiguration : IEntityTypeConfiguration<BIAProcessClient>
    {
        public void Configure(EntityTypeBuilder<BIAProcessClient> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.ProcessClientId });

            builder.ToTable("tblBIAClienteProceso");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.ProcessClientId).ValueGeneratedOnAdd();

            builder.Property(e => e.Process).IsRequired();

            builder.Property(e => e.Product).IsRequired();

            builder.Property(e => e.Responsable).IsRequired();

            builder.Property(e => e.Unit).IsRequired();

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIAProcessClients)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIAClienteProducto_tblBIAProceso");
        }
    }
}
