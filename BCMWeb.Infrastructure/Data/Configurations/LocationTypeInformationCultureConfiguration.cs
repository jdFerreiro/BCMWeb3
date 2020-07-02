using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class LocationTypeInformationCultureConfiguration : IEntityTypeConfiguration<LocationTypeInformationCulture>
    {
        public void Configure(EntityTypeBuilder<LocationTypeInformationCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.LocationTypeInformationId });

            builder.ToTable("tblCultura_TipoUbicacionInformacion");

            builder.HasIndex(e => e.LocationTypeInformationId)
                .HasName("IX_FK_tblCultura_TipoUbicacionInformacion_tblTipoUbicacionInformacion");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(50);

            builder.HasOne(d => d.LocationTypeInformationInfo)
                .WithMany(p => p.LocationTypeInformationCultures)
                .HasForeignKey(d => d.LocationTypeInformationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_TipoUbicacionInformacion_tblTipoUbicacionInformacion");
        }
    }
}
