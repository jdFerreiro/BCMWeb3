using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIACommentConfiguration : IEntityTypeConfiguration<BIAComment>
    {
        public void Configure(EntityTypeBuilder<BIAComment> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.CommentId });

            builder.ToTable("tblBIAComentario");

            builder.Property(e => e.CommentId).ValueGeneratedOnAdd();

            builder.Property(e => e.Description).IsRequired();

            builder.HasOne(d => d.BIADocumentInfo)
                .WithMany(p => p.BIAComments)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIAComentario_tblBIADocumento");
        }
    }
}
