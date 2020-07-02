using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class ImpactLevelConfiguration : IEntityTypeConfiguration<ImpactLevel>
    {
        public void Configure(EntityTypeBuilder<ImpactLevel> builder)
        {
            builder.HasKey(e => e.ImpactLevelId);

            builder.ToTable("tblNivelImpacto");

            builder.Property(e => e.ImpactLevelId).ValueGeneratedNever();
        }
    }
}
