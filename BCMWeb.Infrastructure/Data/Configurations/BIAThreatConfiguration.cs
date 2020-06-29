using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAThreatConfiguration : IEntityTypeConfiguration<BIAThreat>
    {
        public void Configure(EntityTypeBuilder<BIAThreat> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.DocumentId, e.ProcessId, e.ThreatId });

            builder.ToTable("tblBIAAmenaza");

            builder.HasIndex(e => new { e.CompanyId, e.ControlValue })
                .HasName("IX_FK_tblBIAAmenaza_tblControlRiesgo");

            builder.HasIndex(e => new { e.CompanyId, e.StateValue })
                .HasName("IX_FK_tblBIAAmenaza_tblEstadoRiesgo");

            builder.HasIndex(e => new { e.CompanyId, e.SourceValue })
                .HasName("IX_FK_tblBIAAmenaza_tblFuenteRiesgo");

            builder.HasIndex(e => new { e.CompanyId, e.ImpactValue })
                .HasName("IX_FK_tblBIAAmenaza_tblImpactoRiesgo");

            builder.HasIndex(e => new { e.CompanyId, e.ProbabilityValue })
                .HasName("IX_FK_tblBIAAmenaza_tblProbabilidadRiesgo");

            builder.HasIndex(e => new { e.CompanyId, e.SeverityValue })
                .HasName("IX_FK_tblBIAAmenaza_tblSeveridadRiesgo");

            builder.HasIndex(e => new { e.CompanyId, e.DocumentId, e.DocumentTypeId })
                .HasName("IX_FK_tblBIAAmenaza_tblDocumento");

            builder.HasIndex(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId })
                .HasName("IX_FK_tblBIAAmenaza_tblBIAProceso");

            builder.Property(e => e.ThreatId).ValueGeneratedOnAdd();

            builder.Property(e => e.Description).IsRequired();

            builder.Property(e => e.SourceValue)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.HasOne(d => d.RiskControlInfo)
                .WithMany(p => p.BIAThreats)
                .HasForeignKey(d => new { d.CompanyId, d.ControlValue })
                .HasConstraintName("FK_tblBIAAmenaza_tblControlRiesgo");

            builder.HasOne(d => d.RiskStateInfo)
                .WithMany(p => p.BIAThreats)
                .HasForeignKey(d => new { d.CompanyId, d.StateValue })
                .HasConstraintName("FK_tblBIAAmenaza_tblEstadoRiesgo");

            builder.HasOne(d => d.RiskSourceInfo)
                .WithMany(p => p.BIAThreats)
                .HasForeignKey(d => new { d.CompanyId, d.SourceValue })
                .HasConstraintName("FK_tblBIAAmenaza_tblFuenteRiesgo");

            builder.HasOne(d => d.RiskImpactInfo)
                .WithMany(p => p.BIAThreats)
                .HasForeignKey(d => new { d.CompanyId, d.ImpactValue })
                .HasConstraintName("FK_tblBIAAmenaza_tblImpactoRiesgo");

            builder.HasOne(d => d.RiskProbabilityInfo)
                .WithMany(p => p.BIAThreats)
                .HasForeignKey(d => new { d.CompanyId, d.ProbabilityValue })
                .HasConstraintName("FK_tblBIAAmenaza_tblProbabilidadRiesgo");

            builder.HasOne(d => d.RiskSeverityInfo)
                .WithMany(p => p.BIAThreats)
                .HasForeignKey(d => new { d.CompanyId, d.SeverityValue })
                .HasConstraintName("FK_tblBIAAmenaza_tblSeveridadRiesgo");

            builder.HasOne(d => d.DocumentInfo)
                .WithMany(p => p.BIAThreats)
                .HasForeignKey(d => new { d.CompanyId, d.DocumentId, d.DocumentTypeId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIAAmenaza_tblDocumento");

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIAThreats)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIAAmenaza_tblBIAProceso");
        }
    }
}
