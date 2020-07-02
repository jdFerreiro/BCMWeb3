using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BCPRestoreOtherConfiguration : IEntityTypeConfiguration<BCPRestoreOther>
    {
        public void Configure(EntityTypeBuilder<BCPRestoreOther> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BCPDocumentId, e.BCPRestoreOtherId });

            builder.ToTable("tblBCPRestauracionOtro");

            builder.Property(e => e.BCPDocumentId).HasColumnName("IdDocumentoBCP");

            builder.Property(e => e.BCPRestoreOtherId)
                .HasColumnName("IdBCPRestauracionOtro")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(450)
                .IsUnicode(false);

            builder.HasOne(d => d.BCPDocumentInfo)
                .WithMany(p => p.BCPRestoreOthers)
                .HasForeignKey(d => new { d.CompanyId, d.BCPDocumentId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBCPDocumento_tblBCPRestauracionOtro_FK1");
        }
    }
}
