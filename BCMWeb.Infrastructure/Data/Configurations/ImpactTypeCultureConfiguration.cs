using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class ImpactTypeCultureConfiguration : IEntityTypeConfiguration<ImpactTypeCulture>
    {
        public void Configure(EntityTypeBuilder<ImpactTypeCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.ImpactTypeId });

            builder.ToTable("tblCultura_TipoImpacto");

            builder.HasIndex(e => e.ImpactTypeId)
                .HasName("IX_FK_tblCultura_TipoImpacto_tblTipoImpacto");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(50);

            builder.HasOne(d => d.ImpactTypeInfo)
                .WithMany(p => p.ImpactTypeCultures)
                .HasForeignKey(d => d.ImpactTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_TipoImpacto_tblTipoImpacto");
        }
    }
}
