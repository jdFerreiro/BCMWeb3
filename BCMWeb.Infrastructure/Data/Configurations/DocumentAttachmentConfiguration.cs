using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class DocumentAttachmentConfiguration : IEntityTypeConfiguration<DocumentAttachment>
    {
        public void Configure(EntityTypeBuilder<DocumentAttachment> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId, e.AttachmentId });

            builder.ToTable("tblDocumentoAnexo");

            builder.Property(e => e.AttachmentId).ValueGeneratedOnAdd();

            builder.Property(e => e.LastWriteTime).HasColumnType("datetime");

            builder.Property(e => e.Name).HasMaxLength(500);

            builder.HasOne(d => d.DocumentInfo)
                .WithMany(p => p.DocAttachments)
                .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDocumentoAnexo_tblDocumento");
        }
    }
}
