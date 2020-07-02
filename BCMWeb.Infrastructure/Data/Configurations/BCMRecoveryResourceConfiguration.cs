using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BCMRecoveryResourceConfiguration : IEntityTypeConfiguration<BCMRecoveryResource>
    {
        public void Configure(EntityTypeBuilder<BCMRecoveryResource> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BCPDocumentId, e.RecoveryResourceId });

            builder.ToTable("tblBCPRecuperacionRecurso");

            builder.Property(e => e.BCPDocumentId).HasColumnName("IdDocumentoBCP");

            builder.Property(e => e.RecoveryResourceId).ValueGeneratedOnAdd();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250);

            builder.HasOne(d => d.BCPDocumentInfo)
                .WithMany(p => p.BCPRestartResources)
                .HasForeignKey(d => new { d.CompanyId, d.BCPDocumentId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBCPDocumento_tblBCPRecuperacionRecurso_FK1");
        }
    }
}
