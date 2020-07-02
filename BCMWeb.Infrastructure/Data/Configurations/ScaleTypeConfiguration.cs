using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class ScaleTypeConfiguration : IEntityTypeConfiguration<ScaleType>
    {
        public void Configure(EntityTypeBuilder<ScaleType> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.ScaleTypeId });

            builder.ToTable("tblTipoEscala");

            builder.Property(e => e.Description).HasMaxLength(50);
        }
    }
}
