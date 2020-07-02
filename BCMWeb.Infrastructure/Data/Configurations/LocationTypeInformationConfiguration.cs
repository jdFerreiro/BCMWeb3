using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class LocationTypeInformationConfiguration : IEntityTypeConfiguration<LocationTypeInformation>
    {
        public void Configure(EntityTypeBuilder<LocationTypeInformation> builder)
        {
            builder.HasKey(e => e.LocationTypeInformationId);

            builder.ToTable("tblTipoUbicacionInformacion");

            builder.Property(e => e.LocationTypeInformationId).ValueGeneratedNever();
        }
    }
}
