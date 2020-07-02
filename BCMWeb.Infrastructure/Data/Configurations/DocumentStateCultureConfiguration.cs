using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class DocumentStateCultureConfiguration : IEntityTypeConfiguration<DocumentStateCulture>
    {
        public void Configure(EntityTypeBuilder<DocumentStateCulture> builder)
        {
            builder.HasKey(e => new { e.Culture, e.DocumentStateId });

            builder.ToTable("tblCultura_EstadoDocumento");

            builder.HasIndex(e => e.DocumentStateId)
                .HasName("IX_FK_tblCultura_EstadoDocumento_tblEstadoDocumento");

            builder.Property(e => e.Culture)
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Description).HasMaxLength(50);

            builder.HasOne(d => d.DocumentStateInfo)
                .WithMany(p => p.DocumentStateCultures)
                .HasForeignKey(d => d.DocumentStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCultura_EstadoDocumento_tblEstadoDocumento");
        }
    }
}
