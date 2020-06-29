using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAServiceChainConfiguration : IEntityTypeConfiguration<BIAServiceChain>
    {
        public void Configure(EntityTypeBuilder<BIAServiceChain> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ServiceChainId });

            builder.ToTable("tblBIACadenaServicio");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.BIAServiceChains)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIACadenaServicio_tblEmpresa");
        }
    }
}
