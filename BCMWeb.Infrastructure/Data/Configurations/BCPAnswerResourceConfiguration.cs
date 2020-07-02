using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BCPAnswerResourceConfiguration : IEntityTypeConfiguration<BCPAnswerResource>
    {
        public void Configure(EntityTypeBuilder<BCPAnswerResource> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BCPDocumentId, e.BCPAnswerResourceId });

            builder.ToTable("tblBCPRespuestaRecurso");

            builder.Property(e => e.BCPDocumentId).HasColumnName("IdDocumentoBCP");

            builder.Property(e => e.BCPAnswerResourceId).ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne(d => d.BCPDocuments)
                .WithMany(p => p.BCPAnswerResources)
                .HasForeignKey(d => new { d.CompanyId, d.BCPDocumentId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBCPDocumento_tblBCPRespuestaRecurso_FK1");
        }
    }
}
