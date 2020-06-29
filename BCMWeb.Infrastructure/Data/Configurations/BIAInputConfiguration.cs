using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BIAInputConfiguration : IEntityTypeConfiguration<BIAInput>
    {
        public void Configure(EntityTypeBuilder<BIAInput> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BIADocumentId, e.ProcessId, e.InputId });

            builder.ToTable("tblBIAEntrada");

            builder.Property(e => e.BIADocumentId).HasColumnName("IdDocumentoBIA");

            builder.Property(e => e.InputId).ValueGeneratedOnAdd();

            builder.Property(e => e.Event).IsRequired();

            builder.Property(e => e.Responsable).IsRequired();

            builder.Property(e => e.Unit).IsRequired();

            builder.HasOne(d => d.BIAProcessInfo)
                .WithMany(p => p.BIAInputs)
                .HasForeignKey(d => new { d.CompanyId, d.BIADocumentId, d.ProcessId })
                .HasConstraintName("FK_tblBIAEntrada_tblBIAProceso");
        }
    }
}
