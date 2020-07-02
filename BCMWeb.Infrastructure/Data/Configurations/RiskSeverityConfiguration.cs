using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class RiskSeverityConfiguration : IEntityTypeConfiguration<RiskSeverity>
    {
        public void Configure(EntityTypeBuilder<RiskSeverity> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.SeveriryId });

            builder.ToTable("tblSeveridadRiesgo");

            builder.Property(e => e.Name).HasMaxLength(50);
        }
    }
}
