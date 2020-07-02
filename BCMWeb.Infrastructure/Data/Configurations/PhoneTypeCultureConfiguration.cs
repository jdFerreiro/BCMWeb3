using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PhoneTypeCultureConfiguration : IEntityTypeConfiguration<PhoneTypeCulture>
    {
        public void Configure(EntityTypeBuilder<PhoneTypeCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.PhoneTypeId });

            builder.ToTable("tblCultura_TipoTelefono");

            builder.HasIndex(e => e.PhoneTypeId)
                .HasName("IX_FK_tblCultura_TipoTelefono_tblTipoTelefono");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(50);

            builder.HasOne(d => d.PhoneTypeInfo)
                .WithMany(p => p.PhoneTypeCultures)
                .HasForeignKey(d => d.PhoneTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_TipoTelefono_tblTipoTelefono");
        }
    }
}
