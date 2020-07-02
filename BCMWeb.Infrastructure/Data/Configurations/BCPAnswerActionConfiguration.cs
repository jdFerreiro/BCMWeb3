using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BCPAnswerActionConfiguration : IEntityTypeConfiguration<BCPAnswerAction>
    {
        public void Configure(EntityTypeBuilder<BCPAnswerAction> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BCPDocumentId, e.BCPAnswerActionId });

            builder.ToTable("tblBCPRespuestaAccion");

            builder.Property(e => e.BCPDocumentId).HasColumnName("IdDocumentoBCP");

            builder.Property(e => e.BCPAnswerActionId)
                .HasColumnName("IdBCPRespuestaAccion")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.ScaleName)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne(d => d.BCPDocumentInfo)
                .WithMany(p => p.BCPAnswerActions)
                .HasForeignKey(d => new { d.CompanyId, d.BCPDocumentId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBCPRespuestaAccion_tblBCPDocumento");
        }
    }
}
