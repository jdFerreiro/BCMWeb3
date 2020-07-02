using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class IncidentSourceCultureConfiguration : IEntityTypeConfiguration<IncidentSourceCulture>
    {
        public void Configure(EntityTypeBuilder<IncidentSourceCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.IncidentSourceId });

            builder.ToTable("tblCulture_FuenteIncidente");

            builder.HasIndex(e => e.IncidentSourceId)
                .HasName("IX_FK_tblCulture_FuenteIncidente_tblFuenteIncidente");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(250);

            builder.HasOne(d => d.IncidentSourceInfo)
                .WithMany(p => p.IncidentSourceCultures)
                .HasForeignKey(d => d.IncidentSourceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCulture_FuenteIncidente_tblFuenteIncidente");
        }
    }
}
