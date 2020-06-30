using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class DocumentConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId });

            builder.ToTable("tblDocumento");

            builder.HasIndex(e => e.DocumentStateId)
                .HasName("IX_FK_tblDocumento_tblEstadoDocumento");

            builder.Property(e => e.CompanyId)
                .HasColumnName("IdEmpresa");
            builder.Property(e => e.DocumentId)
                .HasColumnName("IdDocumento")
                .ValueGeneratedOnAdd();
            builder.Property(e => e.DocumentTypeId)
                .HasColumnName("IdTipoDocumento");
            builder.Property(e => e.DocumentNumber)
                .HasColumnName("NroDocumento");
            builder.Property(e => e.CreationDate)
                .HasColumnName("FechaCreacion")
                .HasColumnType("datetime");
            builder.Property(e => e.LastUpdateDate)
                .HasColumnName("FechaUltimaModificacion")
                .HasColumnType("datetime");
            builder.Property(e => e.DocumentStateId)
                .HasColumnName("IdEstadoDocumento");
            builder.Property(e => e.DocumentStateDate)
                .HasColumnName("FechaEstadoDocumento")
                .HasColumnType("datetime");
            builder.Property(e => e.IsBusiness)
                .HasColumnName("Negocios")
                .HasColumnType("boolean");
            builder.Property(e => e.VersionNumber)
                .HasColumnName("NroVersion");
            builder.Property(e => e.OriginalVersion)
                .HasColumnName("VersionOriginal");
            builder.Property(e => e.ResponsablePersonId)
                .HasColumnName("IdPersonaResponsable");
            builder.Property(e => e.CertificationRequired)
                .HasColumnName("RequiereCertificacion")
                .HasColumnType("boolean");



            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.Docs)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDocumento_tblEmpresa");

            builder.HasOne(d => d.DocumentStateInfo)
                .WithMany(p => p.Documents)
                .HasForeignKey(d => d.DocumentStateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDocumento_tblEstadoDocumento");
        }
    }
}
