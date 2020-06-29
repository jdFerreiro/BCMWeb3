using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAInterdependecyConfiguration : IEntityTypeConfiguration<BIAInterdependecy>
    {
        public void Configure(EntityTypeBuilder<BIAInterdependecy> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.InterdependencyId });

            builder.ToTable("tblBIAInterdependencia");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.InterdependencyId).ValueGeneratedOnAdd();

            builder.Property(e => e.Contact).IsRequired();

            builder.Property(e => e.Organization).IsRequired();

            builder.Property(e => e.Service).IsRequired();

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIAInterdependencies)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIAInterdependencia_tblBIAProceso");
        }
    }
}
