using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class IncidentTypeCultureConfiguration : IEntityTypeConfiguration<IncidentTypeCulture>
    {
        public void Configure(EntityTypeBuilder<IncidentTypeCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.IncidentTypeId });

            builder.ToTable("tblCulture_TipoIncidente");

            builder.HasIndex(e => e.IncidentTypeId)
                .HasName("IX_FK_tblCulture_TipoIncidente_tblTipoIncidente");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Descripcion).HasMaxLength(250);

            builder.HasOne(d => d.IncidentTypeInfo)
                .WithMany(p => p.IncidentTypeCultures)
                .HasForeignKey(d => d.IncidentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCulture_TipoIncidente_tblTipoIncidente");
        }
    }
}
