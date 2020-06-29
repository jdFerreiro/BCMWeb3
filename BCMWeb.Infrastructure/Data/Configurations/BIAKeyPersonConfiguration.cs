using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAKeyPersonConfiguration : IEntityTypeConfiguration<BIAKeyPerson>
    {
        public void Configure(EntityTypeBuilder<BIAKeyPerson> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.KeyPersonId });

            builder.ToTable("tblBIAPersonaClave");

            builder.HasIndex(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId })
                .HasName("IX_FK_tblBIAPersonaClave_tblDocumento");

            builder.HasIndex(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId, e.KeyPersonId })
                .HasName("IX_FK_tblBIAPersonaClave_tblDocumentoPersonaClave");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.HasOne(d => d.DocumentInfo)
                .WithMany(p => p.BIAVIPPersons)
                .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIAPersonaClave_tblDocumento");

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIAVIPPersons)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIAPersonaClave_tblBIAProceso");

            builder.HasOne(d => d.DocumentKeyPersonInfo)
                .WithMany(p => p.BIAKeyPerson)
                .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId, d.KeyPersonId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIAPersonaClave_tblDocumentoPersonaClave");
        }
    }
}
