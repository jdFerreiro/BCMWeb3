using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class EmailTypeCultureConfiguration : IEntityTypeConfiguration<EmailTypeCulture>
    {
        public void Configure(EntityTypeBuilder<EmailTypeCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.EmailTypeId });

            builder.ToTable("tblCultura_TipoCorreo");

            builder.HasIndex(e => e.EmailTypeId)
                .HasName("IX_FK_tblCultura_TipoCorreo_tblTipoCorreo");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(250);

            builder.HasOne(d => d.EmailTypeInfo)
                .WithMany(p => p.EmailTypeCultures)
                .HasForeignKey(d => d.EmailTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_TipoCorreo_tblTipoCorreo");
        }
    }
}
