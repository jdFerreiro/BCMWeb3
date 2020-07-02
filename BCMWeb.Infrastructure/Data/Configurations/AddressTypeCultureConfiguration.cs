using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class AddressTypeCultureConfiguration : IEntityTypeConfiguration<AddressTypeCulture>
    {
        public void Configure(EntityTypeBuilder<AddressTypeCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.AddressTypeId });

            builder.ToTable("tblCultura_TipoDireccion");

            builder.HasIndex(e => e.AddressTypeId)
                .HasName("IX_FK_tblCultura_TipoDireccion_tblTipoDireccion");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(50);

            builder.HasOne(d => d.AddressTypeInfo)
                .WithMany(p => p.AddressTypeCultures)
                .HasForeignKey(d => d.AddressTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_TipoDireccion_tblTipoDireccion");
        }
    }
}
