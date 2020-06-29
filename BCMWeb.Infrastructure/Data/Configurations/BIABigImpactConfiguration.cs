using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIABigImpactConfiguration : IEntityTypeConfiguration<BIABigImpact>
    {
        public void Configure(EntityTypeBuilder<BIABigImpact> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.BigImpactId, e.MonthId });

            builder.ToTable("tblBIAGranImpacto");

            builder.HasIndex(e => e.MonthId)
                .HasName("IX_FK_tblBIAGranImpacto_tblMes");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.BigImpactId).ValueGeneratedOnAdd();

            builder.Property(e => e.Explain).IsRequired();

            builder.Property(e => e.Comments)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.MonthInfo)
                .WithMany(p => p.BIABigImpact)
                .HasForeignKey(d => d.MonthId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBIAGranImpacto_tblMes");

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIABigImpacts)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIAGranImpacto_tblBIAProceso");
        }
    }
}
