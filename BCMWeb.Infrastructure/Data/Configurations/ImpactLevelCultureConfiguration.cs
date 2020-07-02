using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class ImpactLevelCultureConfiguration : IEntityTypeConfiguration<ImpactLevelCulture>
    {
        public void Configure(EntityTypeBuilder<ImpactLevelCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.ImpactLevelId });

            builder.ToTable("tblCultura_NivelImpacto");

            builder.HasIndex(e => e.ImpactLevelId)
                .HasName("IX_FK_tblCultura_NivelImpacto_tblNivelImpacto");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(50);

            builder.HasOne(d => d.ImpactLevelInfo)
                .WithMany(p => p.ImpactLevelCultures)
                .HasForeignKey(d => d.ImpactLevelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_NivelImpacto_tblNivelImpacto");
        }
    }
}
