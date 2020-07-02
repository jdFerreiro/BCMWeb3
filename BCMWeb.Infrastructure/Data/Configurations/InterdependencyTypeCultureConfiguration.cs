using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class InterdependencyTypeCultureConfiguration : IEntityTypeConfiguration<InterdependencyTypeCulture>
    {
        public void Configure(EntityTypeBuilder<InterdependencyTypeCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.InterdependencyTypeId });

            builder.ToTable("tblCultura_TipoInterdependencia");

            builder.HasIndex(e => e.InterdependencyTypeId)
                .HasName("IX_FK_tblCultura_TipoInterdependencia_tblTipoInterdependencia");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(50);

            builder.HasOne(d => d.InterdependencyTypeInfo)
                .WithMany(p => p.InterdependencyTypeCultures)
                .HasForeignKey(d => d.InterdependencyTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_TipoInterdependencia_tblTipoInterdependencia");
        }
    }
}
