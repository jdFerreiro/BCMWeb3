using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class TableTypeContentCultureConfiguration : IEntityTypeConfiguration<TableTypeContentCulture>
    {
        public void Configure(EntityTypeBuilder<TableTypeContentCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.TableTypeContentId });

            builder.ToTable("tblCultura_TipoTablaContenido");

            builder.HasIndex(e => e.TableTypeContentId)
                .HasName("IX_FK_tblCultura_TipoTablaContenido_tblTipoTablaContenido");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(50);

            builder.HasOne(d => d.TableTypeContentInfo)
                .WithMany(p => p.TableTypeContentCultures)
                .HasForeignKey(d => d.TableTypeContentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_TipoTablaContenido_tblTipoTablaContenido");
        }
    }
}
