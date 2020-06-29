using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAFiancialImpactConfiguration : IEntityTypeConfiguration<BIAFiancialImpact>
    {
        public void Configure(EntityTypeBuilder<BIAFiancialImpact> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.FinancialImpactId });

            builder.ToTable("tblBIAImpactoFinanciero");

            builder.HasIndex(e => e.FrecuencyTypeId)
                .HasName("IX_FK_tblBIAImpactoFinanciero_tblTipoFrecuencia");

            builder.HasIndex(e => new { e.CompanyId, e.ScaleId })
                .HasName("IX_FK_tblBIAImpactoFinanciero_tblEscala");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.FinancialImpactId).ValueGeneratedOnAdd();

            builder.Property(e => e.Description).IsRequired();

            builder.Property(e => e.Impact).IsRequired();

            builder.Property(e => e.TimeUnit).HasMaxLength(450);

            builder.HasOne(d => d.FrecuencyTypeInfo)
                .WithMany(p => p.BIAFinancialImpacts)
                .HasForeignKey(d => d.FrecuencyTypeId)
                .HasConstraintName("FK_tblBIAImpactoFinanciero_tblTipoFrecuencia");

            builder.HasOne(d => d.ScaleInfo)
                .WithMany(p => p.BIAFinancialImpacts)
                .HasForeignKey(d => new { d.CompanyId, d.ScaleId })
                .HasConstraintName("FK_tblBIAImpactoFinanciero_tblEscala");

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIAFinancialImpacts)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIAImpactoFinanciero_tblBIAProceso");
        }
    }
}
