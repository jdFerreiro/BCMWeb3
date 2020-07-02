using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class RiskControlConfiguration : IEntityTypeConfiguration<RiskControl>
    {
        public void Configure(EntityTypeBuilder<RiskControl> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ControlId });

            builder.ToTable("tblControlRiesgo");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
