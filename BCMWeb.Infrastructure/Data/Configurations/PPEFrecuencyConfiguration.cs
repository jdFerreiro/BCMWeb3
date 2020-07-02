using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class PPEFrecuencyConfiguration : IEntityTypeConfiguration<PPEFrecuency>
    {
        public void Configure(EntityTypeBuilder<PPEFrecuency> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId, e.PPEFrecuencyId });

            builder.ToTable("tblPPEFrecuencia");

            builder.HasIndex(e => e.FrecuencyTypeId)
                .HasName("IX_FK_tblPPEFrecuencia_tblTipoFrecuencia");

            builder.Property(e => e.PPEFrecuencyId)
                .HasColumnName("IdPPEFrecuencia")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Participants)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.Purpose)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.TestType)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.FrecuencyTypeInfo)
                .WithMany(p => p.PPEFrecuencies)
                .HasForeignKey(d => d.FrecuencyTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPPEFrecuencia_tblTipoFrecuencia");

            builder.HasOne(d => d.DocumentInfo)
                .WithMany(p => p.PPEFrecuencies)
                .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblPPEFrecuencia_tblDocumento");
        }
    }
}
