using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BCPRestoreInfraestructureConfiguration : IEntityTypeConfiguration<BCPRestoreInfraestructure>
    {
        public void Configure(EntityTypeBuilder<BCPRestoreInfraestructure> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BCPDocumentId, e.BCPRestoreInfraestructureId });

            builder.ToTable("tblBCPRestauracionInfraestructura");

            builder.Property(e => e.BCPDocumentId).HasColumnName("IdDocumentoBCP");

            builder.Property(e => e.BCPRestoreInfraestructureId)
                .HasColumnName("IdBCPRestauracionInfraestructura")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.BCPDocumentInfo)
                .WithMany(p => p.BCPRestoreInfrastructures)
                .HasForeignKey(d => new { d.CompanyId, d.BCPDocumentId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBCPDocumento_tblBCPRestauracionInfraestructura_FK1");
        }
    }
}
