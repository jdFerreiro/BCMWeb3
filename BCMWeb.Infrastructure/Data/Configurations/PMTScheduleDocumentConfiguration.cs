using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PMTScheduleDocumentConfiguration : IEntityTypeConfiguration<PMTScheduleDocument>
    {
        public void Configure(EntityTypeBuilder<PMTScheduleDocument> builder)
        {
            builder.HasKey(e => new { e.PMTScheduleId, e.CompanyId, e.MenuOptionId, e.DocumentId });

            builder.ToTable("tblPMTProgramacionDocumentos");

            builder.HasIndex(e => new { e.CompanyId, e.MenuOptionId })
                .HasName("IX_FK_tblPMTProgramacionDocumentos_tblModulo");

            builder.HasIndex(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId })
                .HasName("IX_FK_tblPMTProgramacionDocumentos_tblDocumento");

            builder.Property(e => e.PMTScheduleId).HasColumnName("IdPMTProgramacion");

            builder.HasOne(d => d.PMTScheduleInfo)
                .WithMany(p => p.PMTScheduleDocuments)
                .HasForeignKey(d => d.PMTScheduleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPMTProgramacionDocumentos_tblPMTProgramacion");

            builder.HasOne(d => d.MenuOptionInfo)
                .WithMany(p => p.PMTScheduleDocuments)
                .HasForeignKey(d => new { d.CompanyId, d.MenuOptionId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPMTProgramacionDocumentos_tblModulo");

            builder.HasOne(d => d.DocumentInfo)
                .WithMany(p => p.PMTDocumentSchedules)
                .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPMTProgramacionDocumentos_tblDocumento");
        }
    }
}
