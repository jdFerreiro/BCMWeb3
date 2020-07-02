using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class DocumentInterviewPersonConfiguration : IEntityTypeConfiguration<DocumentInterviewPerson>
    {
        public void Configure(EntityTypeBuilder<DocumentInterviewPerson> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId, e.InterviewId, e.InterviewPersonId });

            builder.ToTable("tblDocumentoEntrevistaPersona");

            builder.Property(e => e.CompanyName).HasMaxLength(1500);

            builder.Property(e => e.Name).HasMaxLength(1500);

            builder.HasOne(d => d.DocumentInterviewInfo)
                .WithMany(p => p.DocumentInterviewPersons)
                .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId, d.InterviewId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblDocumentoEntrevistaPersona_tblDocumentoEntrevista");
        }
    }
}
