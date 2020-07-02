using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class FrecuencyTypeConfiguration : IEntityTypeConfiguration<FrecuencyType>
    {
        public void Configure(EntityTypeBuilder<FrecuencyType> builder)
        {
            builder.HasKey(e => e.FrecuencyTypeId);

            builder.ToTable("tblTipoFrecuencia");

            builder.Property(e => e.FrecuencyTypeId).ValueGeneratedNever();
        }
    }
}
