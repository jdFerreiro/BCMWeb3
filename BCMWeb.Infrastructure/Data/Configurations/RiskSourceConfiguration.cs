using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class RiskSourceConfiguration : IEntityTypeConfiguration<RiskSource>
    {
        public void Configure(EntityTypeBuilder<RiskSource> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.SourceCode });

            builder.ToTable("tblFuenteRiesgo");

            builder.Property(e => e.SourceCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
