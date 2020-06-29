using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BCPDocumentConfiguration : IEntityTypeConfiguration<BCPDocument>
    {
        public void Configure(EntityTypeBuilder<BCPDocument> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BCPDocumentId });

            builder.ToTable("tblBCPDocumento");

            builder.HasIndex(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId })
                .HasName("IX_FK_tblBCPDocumento_tblDocumento");

            builder.HasIndex(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId })
                .HasName("IX_FK_tblBCPDocumento_tblBIAProceso");

            builder.Property(e => e.BCPDocumentId)
                .HasColumnName("IdDocumentoBCP")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.ProcessName).HasMaxLength(500);

            builder.Property(e => e.ResponsabileName).HasMaxLength(500);

            builder.Property(e => e.SubprocessName).HasMaxLength(500);

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.BCPDocs)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmpresa_tblBCPDocumento_FK1");

            builder.HasOne(d => d.DocumentInfo)
                .WithMany(p => p.BCPDocs)
                .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                .HasConstraintName("FK_tblBCPDocumento_tblDocumento");

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BCPDocuments)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_tblBCPDocumento_tblBIAProceso");
        }
    }
}
