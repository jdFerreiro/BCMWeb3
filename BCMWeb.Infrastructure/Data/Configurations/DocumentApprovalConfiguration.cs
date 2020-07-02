using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class DocumentApprovalConfiguration : IEntityTypeConfiguration<DocumentApproval>
    {
        public void Configure(EntityTypeBuilder<DocumentApproval> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentType, e.ApprovalId });

            builder.ToTable("tblDocumentoAprobacion");

            builder.HasIndex(e => new { e.CompanyId, e.PersonId })
                .HasName("IX_FK_tblDocumentoAprobacion_tblPersona");

            builder.Property(e => e.ApprovalId).ValueGeneratedOnAdd();

            builder.Property(e => e.ApprovalDate).HasColumnType("datetime");

            builder.HasOne(d => d.PersonInfo)
                .WithMany(p => p.DocApprovals)
                .HasForeignKey(d => new { d.CompanyId, d.PersonId })
                .HasConstraintName("FK_tblDocumentoAprobacion_tblPersona");

            builder.HasOne(d => d.DocumentInfo)
                .WithMany(p => p.DocumentAprovals)
                .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentType })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblAprobacion_tblDocumento");
        }
    }
}
