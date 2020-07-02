using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class ImpactTypeConfiguration : IEntityTypeConfiguration<ImpactType>
    {
        public void Configure(EntityTypeBuilder<ImpactType> builder)
        {
            builder.HasKey(e => e.ImpactTypeId);

            builder.ToTable("tblTipoImpacto");

            builder.Property(e => e.ImpactTypeId).ValueGeneratedNever();
        }
    }
}
