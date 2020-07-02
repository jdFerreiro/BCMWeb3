using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PersonAddressConfiguration : IEntityTypeConfiguration<PersonAddress>
    {
        public void Configure(EntityTypeBuilder<PersonAddress> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.PersonId, e.PersonAddressId });

            builder.ToTable("tblPersonaDireccion");

            builder.HasIndex(e => e.CountryId)
                .HasName("IX_FK_tblPersonaDireccion_tblPais");

            builder.HasIndex(e => e.AddressTypeId)
                .HasName("IX_FK_tblPersonaDireccion_tblTipoDireccion");

            builder.HasIndex(e => new { e.CountryId, e.StateId })
                .HasName("IX_FK_tblPersonaDireccion_tblEstado");

            builder.HasIndex(e => new { e.CountryId, e.StateId, e.CityId })
                .HasName("IX_FK_tblPersonaDireccion_tblCiudad");

            builder.Property(e => e.PersonAddressId).ValueGeneratedOnAdd();

            builder.Property(e => e.LocationName).HasMaxLength(1500);

            builder.HasOne(d => d.CountryInfo)
                .WithMany(p => p.PersonAddresses)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPersonaDireccion_tblPais");

            builder.HasOne(d => d.AddressTypeInfo)
                .WithMany(p => p.AddressPersons)
                .HasForeignKey(d => d.AddressTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPersonaDireccion_tblTipoDireccion");

            builder.HasOne(d => d.PersonInfo)
                .WithMany(p => p.PersonAddress)
                .HasForeignKey(d => new { d.CompanyId, d.PersonId })
                .HasConstraintName("FK_tblPersona_tblPersonaDireccion_FK1");

            builder.HasOne(d => d.StateInfo)
                .WithMany(p => p.PersonAddresses)
                .HasForeignKey(d => new { d.CountryId, d.StateId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPersonaDireccion_tblEstado");

            builder.HasOne(d => d.CityInfo)
                .WithMany(p => p.PersonAddresses)
                .HasForeignKey(d => new { d.CountryId, d.StateId, d.CityId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPersonaDireccion_tblCiudad");
        }
    }
}
