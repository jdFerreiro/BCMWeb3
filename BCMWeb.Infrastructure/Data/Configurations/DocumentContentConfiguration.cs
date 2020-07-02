using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class DocumentContentConfiguration : IEntityTypeConfiguration<DocumentContent>
    {
        public void Configure(EntityTypeBuilder<DocumentContent> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId, e.MenuOptionId });

            builder.ToTable("tblDocumentoContenido");

            builder.HasIndex(e => new { e.CompanyId, e.MenuOptionId })
                .HasName("IX_FK_tblDocumentoContenido_tblModulo");

            builder.Property(e => e.CreatedDate).HasColumnType("datetime");

            builder.HasOne(d => d.MenuOptionInfo)
                .WithMany(p => p.DocumentContents)
                .HasForeignKey(d => new { d.CompanyId, d.MenuOptionId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDocumentoContenido_tblModulo");

            builder.HasOne(d => d.DocumentInfo)
                .WithMany(p => p.DocumentContents)
                .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDocumentoContenido_tblDocumento");
        }
    }
}
