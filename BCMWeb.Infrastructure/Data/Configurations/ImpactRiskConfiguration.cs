using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class ImpactRiskConfiguration : IEntityTypeConfiguration<ImpactRisk>
    {
        public void Configure(EntityTypeBuilder<ImpactRisk> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ImpactId });

            builder.ToTable("tblImpactoRiesgo");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
