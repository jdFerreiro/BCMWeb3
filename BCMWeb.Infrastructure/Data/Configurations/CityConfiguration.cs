using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(e => new { e.CountryId, e.StateId, e.CityId });

            builder.ToTable("tblCiudad");

            builder.HasOne(d => d.CountryInfo)
                .WithMany(p => p.Cities)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCiudad_tblPais");

            builder.HasOne(d => d.StateInfo)
                .WithMany(p => p.Cities)
                .HasForeignKey(d => new { d.CountryId, d.StateId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCiudad_tblEstado");
        }
    }
}
