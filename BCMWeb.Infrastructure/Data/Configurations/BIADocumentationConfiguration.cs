using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIADocumentationConfiguration : IEntityTypeConfiguration<BIADocumentation>
    {
        public void Configure(EntityTypeBuilder<BIADocumentation> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.DocumentId });

            builder.ToTable("tblBIADocumentacion");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.DocumentId).ValueGeneratedOnAdd();

            builder.Property(e => e.Name).IsRequired();

            builder.Property(e => e.Location).IsRequired();

            builder.HasOne(d => d.BIAPRocessInfo)
                .WithMany(p => p.BIADocs)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIADocumentacion_tblBIAProceso");
        }
    }
}
