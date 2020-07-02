using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class CityCultureConfiguration : IEntityTypeConfiguration<CityCulture>
    {
        public void Configure(EntityTypeBuilder<CityCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.CountryId, e.StateId, e.CityId });

            builder.ToTable("tblCultura_Ciudad");

            builder.HasIndex(e => new { e.CountryId, e.StateId, e.CityId })
                .HasName("IX_FK_tblCulture_Ciudad_tblCiudad");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Name).HasMaxLength(250);

            builder.HasOne(d => d.CityInfo)
                .WithMany(p => p.CityCultures)
                .HasForeignKey(d => new { d.CountryId, d.StateId, d.CityId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCulture_Ciudad_tblCiudad");
        }
    }
}
