using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAOperationaImpactConfiguration : IEntityTypeConfiguration<BIAOperationalImpact>
    {
        public void Configure(EntityTypeBuilder<BIAOperationalImpact> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.OperationalImpactId });

            builder.ToTable("tblBIAImpactoOperacional");

            builder.HasIndex(e => e.FrecuencyTypeId)
                .HasName("IX_FK_tblBIAImpactoOperacional_tblTipoFrecuencia");

            builder.HasIndex(e => new { e.CompanyId, e.ScaleId })
                .HasName("IX_FK_tblBIAImpactoOperacional_tblEscala");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.OperationalImpactId).ValueGeneratedOnAdd();

            builder.Property(e => e.Description).IsRequired();

            builder.Property(e => e.OperationalImpact)
                .IsRequired()
                .HasMaxLength(450);

            builder.Property(e => e.TimeUnit).HasMaxLength(450);

            builder.HasOne(d => d.FrecuencyTypeInfo)
                .WithMany(p => p.BIAOperationalImpacts)
                .HasForeignKey(d => d.FrecuencyTypeId)
                .HasConstraintName("FK_tblBIAImpactoOperacional_tblTipoFrecuencia");

            builder.HasOne(d => d.ScaleInfo)
                .WithMany(p => p.BIAOperationalImpacts)
                .HasForeignKey(d => new { d.CompanyId, d.ScaleId })
                .HasConstraintName("FK_tblBIAImpactoOperacional_tblEscala");

            builder.HasOne(d => d.ProcessInfo)
                .WithMany(p => p.BIAOperationalImpacts)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIAImpactoOperacional_tblBIAProceso");
        }
    }
}
