using BCMWeb.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BCMWeb.Infrastructure.Data.Configurations
{
    public class BCPResumptionKitConfiguration : IEntityTypeConfiguration<BCPResumptionKit>
    {
        public void Configure(EntityTypeBuilder<BCPResumptionKit> builder)
        {
            builder.HasKey(e => new { e.CompanyId, e.BCPDocumentId, e.BCPResumptionKitId });

            builder.ToTable("tblBCPRestauracionEquipo");

            builder.Property(e => e.BCPDocumentId).HasColumnName("IdDocumentoBCP");

            builder.Property(e => e.BCPResumptionKitId)
                .HasColumnName("IdBCPRestauracionEquipo")
                .ValueGeneratedOnAdd();

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(450);

            builder.HasOne(d => d.BCPDocumentInfo)
                .WithMany(p => p.BCPRestoreKits)
                .HasForeignKey(d => new { d.CompanyId, d.BCPDocumentId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_tblBCPDocumento_tblBCPRestauracionEquipo_FK1");
        }
    }
}
