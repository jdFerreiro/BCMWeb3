using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIADocumentConfiguration : IEntityTypeConfiguration<BIADocument>
    {
        public void Configure(EntityTypeBuilder<BIADocument> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId });

            builder.ToTable("tblBIADocumento");

            builder.HasIndex(e => new { e.CompanyId, e.OUId })
                .HasName("IX_FK_tblBIADocumento_tblUnidadOrganizativa");

            builder.HasIndex(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId })
                .HasName("IX_FK_tblDocumento_tblBIADocumento");

            builder.Property(e => e.BIADocumentId)
                .HasColumnName("IdDocumentoBIA")
                .ValueGeneratedOnAdd();

            builder.HasOne(d => d.CompanyInfo)
                .WithMany(p => p.BIADocs)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblEmpresa_tblBIADocumento_FK1");

            builder.HasOne(d => d.OUInfo)
                .WithMany(p => p.BIADocuments)
                .HasForeignKey(d => new { d.CompanyId, d.OUId })
                .HasConstraintName("FK_tblBIADocumento_tblUnidadOrganizativa");

            builder.HasOne(d => d.DocumentInfo)
                .WithMany(p => p.BiaDocs)
                .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                .HasConstraintName("FK_tblDocumento_tblBIADocumento");
        }
    }
}
