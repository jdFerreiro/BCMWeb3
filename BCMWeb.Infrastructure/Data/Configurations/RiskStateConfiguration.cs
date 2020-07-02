using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class RiskStateConfiguration : IEntityTypeConfiguration<RiskState>
    {
        public void Configure(EntityTypeBuilder<RiskState> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.RiskStateId });

            builder.ToTable("tblEstadoRiesgo");

            builder.Property(e => e.Color)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);
        }
    }
}
