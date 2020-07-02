using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.LocationId });

            builder.ToTable("tblLocalidad");

            builder.HasIndex(e => e.CountryId)
                .HasName("IX_FK_tblLocalidad_tblPais");

            builder.HasIndex(e => new { e.CountryId, e.StateId })
                .HasName("IX_FK_tblLocalidad_tblEstado");

            builder.HasIndex(e => new { e.CountryId, e.StateId, e.CityId })
                .HasName("IX_FK_tblLocalidad_tblCiudad");

            builder.Property(e => e.LocationId).ValueGeneratedOnAdd();

            builder.Property(e => e.LocationCode)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.Locations)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmpresa_tblLocalidad_FK1");

            builder.HasOne(d => d.CountryInfo)
                .WithMany(p => p.Locations)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLocalidad_tblPais");

            builder.HasOne(d => d.StateInfo)
                .WithMany(p => p.Locations)
                .HasForeignKey(d => new { d.CountryId, d.StateId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLocalidad_tblEstado");

            builder.HasOne(d => d.CityInfo)
                .WithMany(p => p.Locations)
                .HasForeignKey(d => new { d.CountryId, d.StateId, d.CityId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblLocalidad_tblCiudad");
        }
    }
}
