using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAAppConfiguration : IEntityTypeConfiguration<BIAApp>
    {
        public void Configure(EntityTypeBuilder<BIAApp> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.AppId });

            builder.ToTable("tblBIAAplicacion");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.AppId).ValueGeneratedOnAdd();

            builder.Property(e => e.Name).IsRequired();

            builder.Property(e => e.User).IsRequired();

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIAApps)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIAAplicacion_tblBIAProceso");
        }
    }
}
