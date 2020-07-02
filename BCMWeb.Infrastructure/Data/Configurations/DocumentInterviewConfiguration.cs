using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class DocumentInterviewConfiguration : IEntityTypeConfiguration<DocumentInterview>
    {
        public void Configure(EntityTypeBuilder<DocumentInterview> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId, e.InterviewId });

            builder.ToTable("tblDocumentoEntrevista");

            builder.Property(e => e.InterviewId).ValueGeneratedOnAdd();

            builder.Property(e => e.EndDate).HasColumnType("datetime");

            builder.Property(e => e.StartDate).HasColumnType("datetime");

            builder.HasOne(d => d.DocumentInfo)
                .WithMany(p => p.DocumentInterviews)
                .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDocumentoEntrevista_tblDocumento");
        }
    }
}
