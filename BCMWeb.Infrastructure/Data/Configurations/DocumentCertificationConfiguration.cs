using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class DocumentCertificationConfiguration : IEntityTypeConfiguration<DocumentCertification>
    {
        public void Configure(EntityTypeBuilder<DocumentCertification> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId, e.CertificationId });

            builder.ToTable("tblDocumentoCertificacion");

            builder.HasIndex(e => new { e.CompanyId, e.PersonId })
                .HasName("IX_FK_tblCertificacion_tblPersona");

            builder.Property(e => e.CertificationId).ValueGeneratedOnAdd();

            builder.Property(e => e.CertificationDate).HasColumnType("datetime");

            builder.HasOne(d => d.PersonInfo)
                .WithMany(p => p.DocsCertifications)
                .HasForeignKey(d => new { d.CompanyId, d.PersonId })
                .HasConstraintName("FK_tblCertificacion_tblPersona");

            builder.HasOne(d => d.DocumentInfo)
                .WithMany(p => p.DocumentCertifications)
                .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblCertificacion_tblDocumento");
        }
    }
}
