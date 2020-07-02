using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class FrecuencyTypeCultureConfiguration : IEntityTypeConfiguration<FrecuencyTypeCulture>
    {
        public void Configure(EntityTypeBuilder<FrecuencyTypeCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.FrecuencyTypeId });

            builder.ToTable("tblCultura_TipoFrecuencia");

            builder.HasIndex(e => e.FrecuencyTypeId)
                .HasName("IX_FK_tblCultura_TipoFrecuencia_tblTipoFrecuencia");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(450);

            builder.HasOne(d => d.FrecuencyTypeInfo)
                .WithMany(p => p.FrecuencyTypeCultures)
                .HasForeignKey(d => d.FrecuencyTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_TipoFrecuencia_tblTipoFrecuencia");
        }
    }
}
